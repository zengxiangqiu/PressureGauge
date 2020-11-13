using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 压力监控系统_初版
{
    public partial class Mainform : Form
    {
        //实例化串口
        SerialPort serialPort = new SerialPort();
        string saveDataFile = null;
        FileStream saveDataFS = null;


        private bool Listening = false;//是否没有执行完invoke相关操作
        private bool Closing = false;//是否正在关闭串口，执行Application.DoEvents，并阻止再次invoke
        private List<byte> buffer = new List<byte>(4096);//默认分配1页内存，并始终限制不允许超过
        private byte[] binary_data_1 = new byte[15];//01 03 0a 52 47 00 04 00 00 30 39 00 04 0a c0 

        DateTime dateofpressure = DateTime.Now;

        public Mainform()
        {
            InitializeComponent();
        }
        //初始化串口界面参数
        private void Init_Port_Confs()
        {
            string[] portname = SerialPort.GetPortNames();

            if (portname == null)
            {
                MessageBox.Show("没有连接", "error");
                return;
            }

             ///添加串口
            //foreach (string name in portname )
            //{
            //    PortNameCbb.Items.Add(name);
            //}
            //PortNameCbb.SelectedIndex = 0;

            //COM Ports
            string[] ArrayComPortsNames = SerialPort.GetPortNames();

            if (ArrayComPortsNames.Length == 0)
            {
                statuslabel.Text = "没有找到串口";
                OpenCloseBto.Enabled = false;
            }
            else
            {
                Array.Sort(ArrayComPortsNames);
                for (int i = 0; i < ArrayComPortsNames.Length; i++)
                {
                    PortNameCbb.Items.Add(ArrayComPortsNames[i]);
                }
                PortNameCbb.Text = ArrayComPortsNames[0];
                OpenCloseBto.Enabled = true;
            }

            //BaudRate
            BaudRateCbb.Items.Add(2400);
            BaudRateCbb.Items.Add(4800);
            BaudRateCbb.Items.Add(9600);
            BaudRateCbb.Items.Add(19200);
            BaudRateCbb.Items.Add(38400);
            BaudRateCbb.Items.ToString();
            BaudRateCbb.Text = BaudRateCbb.Items[2].ToString();

            //Data Bits
            DataBitsCbb.Items.Add(5);
            DataBitsCbb.Items.Add(6);
            DataBitsCbb.Items.Add(7);
            DataBitsCbb.Items.Add(8);
            DataBitsCbb.Items.ToString();
            DataBitsCbb.Text = DataBitsCbb.Items[3].ToString();


            //Stop Bits
            StopBitsCbb.Items.Add("1");
            StopBitsCbb.Items.Add("1.5");
            StopBitsCbb.Items.Add("2");
            StopBitsCbb.Text = StopBitsCbb.Items[0].ToString();

            //Parity
            ParityCbb.Items.Add("None");
            ParityCbb.Items.Add("Even");
            ParityCbb.Items.Add("Mark");
            ParityCbb.Items.Add("Odd");
            ParityCbb.Items.Add("Space");
            ParityCbb.Text = ParityCbb.Items[0].ToString();

            //数据格式设置
            sendStrRadiobto.Checked = true;
            recStrRadBto.Checked = true;
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            Init_Port_Confs();

            Control.CheckForIllegalCrossThreadCalls = false;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(dataReceived);

            //ready，默认优先使用RS485

            if (RS485CheckBox.Checked)
            {
                serialPort.DtrEnable = true;
                serialPort.RtsEnable = true;
            }
            else
            {
                serialPort.DtrEnable = false;
                serialPort.RtsEnable = false;
            }


            serialPort.Close();
            sendBto.Enabled = false;
        }

        private void OpenCloseBto_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                try
                {
                    if (PortNameCbb.SelectedIndex == -1)
                    {
                        MessageBox.Show("Error: 无效端口，请重新选择", "error");
                        return;
                    }
                    string SerialName_com = PortNameCbb.SelectedItem.ToString();
                    string BaudRate_com = BaudRateCbb.SelectedItem.ToString();
                    string StopBits_com = StopBitsCbb.SelectedItem.ToString();
                    string Parity_com = ParityCbb.SelectedItem.ToString();
                    string DataBits_com = DataBitsCbb.SelectedItem.ToString();

                    Int32 iBaudRate = Convert.ToInt32(BaudRate_com);
                    Int32 iDataBits = Convert.ToInt32(DataBits_com);

                    serialPort.PortName = SerialName_com;//串口号
                    serialPort.BaudRate = iBaudRate;//波特率
                    serialPort.DataBits = iDataBits;//数据位

                    //StopBits
                    switch (StopBits_com)
                    {
                        case "1":
                            serialPort.StopBits = StopBits.One;
                            break;
                        case "2":
                            serialPort.StopBits = StopBits.Two;
                            break;
                        case "1.5":
                            serialPort.StopBits = StopBits.OnePointFive;
                            break;
                        default:
                            MessageBox.Show("Error:参数错误", "Error");
                            break;
                    }
                    //Parity
                    switch (Parity_com)
                    {
                        case "None":
                            serialPort.Parity = Parity.None;
                            break;
                        case "Odd":
                            serialPort.Parity = Parity.Odd;
                            break;
                        case "Even":
                            serialPort.Parity = Parity.Even;
                            break;
                        case "Mark":
                            serialPort.Parity = Parity.Mark;
                            break;
                        default:
                            MessageBox.Show("Error：参数错误", "Errorc");
                            break;
                    }

                    if (saveDataFile != null)
                    {
                        saveDataFS = File.Create(saveDataFile);
                    }


                    //Open Serial Port
                    serialPort.Open();

                    PortNameCbb.Enabled = false;
                    BaudRateCbb.Enabled = false;
                    StopBitsCbb.Enabled = false;
                    ParityCbb.Enabled = false;
                    DataBitsCbb.Enabled = false;

                    recStrRadBto.Enabled = false;
                    
                    sendStrRadiobto.Enabled = false;

                    sendBto.Enabled = true;
                    refreshBto.Enabled = false;

                    OpenCloseBto.Text = "Close";
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Error");
                    return;
                }

            }

            else //Serial Port is opened;
            {
                serialPort.Close();

                PortNameCbb.Enabled = true;
                BaudRateCbb.Enabled = true;
                StopBitsCbb.Enabled = true;
                ParityCbb.Enabled = true;
                DataBitsCbb.Enabled = true;

                recStrRadBto.Enabled = true;
                sendStrRadiobto.Enabled = true;

                sendBto.Enabled = false;
                refreshBto.Enabled = true;

                OpenCloseBto.Text = "Open";

                if (saveDataFS != null)
                {
                    saveDataFS.Close();
                    saveDataFS = null;
                }
            }
        }

        #region**以后修改**

        //Received&Send
        //private void dataSendReceived(object sender, SerialDataReceivedEventArgs e)
        //{

        //    if (serialPort.IsOpen && OpenCloseBto.Text =="Close")
        //    {
        //        DateTime datetime_now = DateTime.Now;
        //        receiveTxt.Text += string.Format("{0}\r\n", datetime_now);
        //        receiveTxt.ForeColor = Color.Blue;

        //        waittime .Interval =100;
        //        waittime.Enabled = false;

        //        //发送指令
        //        serialPort.WriteLine(sendTxt.Text);
        //        ////等待时间
        //        //waittime.Enabled  =true;
        //        //接收指令


        //        string input = serialPort.ReadLine();
        //        receiveTxt.Text += input + "\r\n";


        //    }
        //    else 
        //    {

        //        MessageBox.Show("串口尚未打开", "Error");
        //        return;

        //    }
        //}
        #endregion

        //Received
        private void dataReceived(object sender, SerialDataReceivedEventArgs e)
        {


            this.Invoke((EventHandler)(delegate
           {
               if (RS485CheckBox.Checked)
               {
                    dataReceived_485();
                   }
               else
               {
                   dataReceived_Sample();
               }
           }));
        }

        //485
        private void dataReceived_485()
        {
            #region**早期版本**
            if (Closing) return;

            try
            {
                //延时50ms确保能够接收完整数据
                System.Threading.Thread.Sleep(100);
                //开始采集数据
                Listening = true;
                int n = serialPort.BytesToRead;
                byte[] buf = new byte[n];
                serialPort.Read(buf, 0, n);//读取缓存数据

                bool data_catched = false;//标志位判断是否缓存成功

                //缓存数据
                buffer.AddRange(buf);
                //是否完整
                while (buffer.Count >= 3 & buffer.Count <= binary_data_1.Length)
                {
                    if (buffer[1] == 0x03 & buffer[2] == 0x0a)
                    {
                        if (buffer.Count < binary_data_1.Length)
                            break;
                        byte[] Check_In = new byte[binary_data_1.Length-2];
                        for (int i = 0; i < binary_data_1.Length-2; i++)
                        {
                            Check_In[i] = buffer[i];
                        }

                        byte[] Check_Out = CRC16_C(Check_In);
                        if (Check_Out[0] != buffer[binary_data_1.Length-2] || Check_Out[1] != buffer[binary_data_1.Length-1])
                        {
                            buffer.RemoveRange(0, buffer.Count);
                        }

                        buffer.CopyTo(0, binary_data_1, 0, buffer.Count);
                        data_catched = true;
                        buffer.RemoveRange(0, buffer.Count);
                    }
                    else//数据错误时，需要删除数据
                    {
                        buffer.RemoveAt(0);
                    }
                }
                #endregion
               
                
                #region**分析数据和显示数据**
                //分析数据
                if (data_catched)
                {
                    //string dataPressure = null;
                    double xiaoshu;
                    string Pressure = null;
                    // string PressureLow = null;
                    string unit = null;
                    double Pressure_Output = 0.0000;

                    //单位
                    switch (unit)
                    {
                        case "3": unit = "kPa"; break;
                        case "4": unit = "Mpa"; break;
                        case "5": unit = "Pa"; break;
                    }
                    xiaoshu = Convert.ToDouble(binary_data_1[6].ToString());
                    Pressure_Output = (int.Parse(binary_data_1[8].ToString()) * 10000 +
                    int.Parse(binary_data_1[9].ToString()) * 100 + int.Parse(binary_data_1[10].ToString())) / Math.Pow(10, xiaoshu);


                    Pressure_Output = Math.Round(Pressure_Output, 5);

                    //最后输出的压力值
                    Pressure = Convert.ToString(Pressure_Output) + unit;
                    dateofpressure = DateTime.Now;

                    ////地址位
                    //if (binary_data_1[0].ToString() == strAddr && Pressure_Output <= 99999)
                    //{
                    //    this.Invoke ((EventHandler )(delegate { }))
                    //}

                    //显示数据
                    receiveTxt.Text += string.Format("{0}\r\n", dateofpressure);
                    receiveTxt.ForeColor = Color.Blue;

                    if (recStrRadBto.Checked)
                    {
                        try
                        {
                            string input = Pressure;
                            receiveTxt.Text += input + "\r\n";
                            if (saveDataFS != null)
                            {
                                byte[] info = new UTF8Encoding(true).GetBytes(input + "\r\n");
                                saveDataFS.Write(info, 0, info.Length);
                            }
                        }
                        catch (System.Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error");
                        }
                        receiveTxt.SelectionStart = receiveTxt.Text.Length;
                        receiveTxt.ScrollToCaret();
                        serialPort.DiscardInBuffer();
                    }


                }
                #endregion
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
 #region**全双工**   
            private void dataReceived_Sample()
        { 
            if (serialPort.IsOpen)
            {
                DateTime datatime_now = DateTime.Now;
                receiveTxt.Text += string.Format("{0}\r\n", datatime_now);
                receiveTxt.ForeColor = Color.Blue;

                if (recStrRadBto.Checked == true)
                {
                    try
                    {
                        string input = serialPort.ReadLine();
                        receiveTxt.Text += input + "\r\n";

                        if (saveDataFS != null)
                        {
                            byte[] info = new UTF8Encoding(true).GetBytes(input + "\r\n");
                            saveDataFS.Write(info, 0, info.Length);
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                        return;
                    }

                    receiveTxt.SelectionStart = receiveTxt.Text.Length;
                    receiveTxt.ScrollToCaret();
                    serialPort.DiscardInBuffer();
                }
                else
                {
                    try
                    {
                        string input = serialPort.ReadLine();
                        char[] value = input.ToCharArray();
                        foreach (char letter in value)
                        {
                            int values = Convert.ToInt32(letter);
                            string HexOutput = String.Format("{0:X}", values);
                            receiveTxt.AppendText(HexOutput + " ");
                            receiveTxt.SelectionStart = receiveTxt.Text.Length;
                            receiveTxt.ScrollToCaret();
                        }

                        if (saveDataFS != null)
                        {
                            byte[] info = new UTF8Encoding(true).GetBytes(input + "\r\n");
                            saveDataFS.Write(info, 0, info.Length);
                        }

                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                        receiveTxt.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Error:请打开串口", "Error");
            }
            #endregion
        }

        //send Event
        private string strOrder = null;
        private void orderSend(string strSend, int isCRCorNot)
        {
            //先清空缓存区
            buffer.Clear();
            //记录发送字节
            int n = 0;
            byte[] CRCArry = new byte[2];

            //16进制发送
            if (true)
            {
                strSend = strSend.Replace(" ", "");
                if ((strSend.Length % 2) != 0)
                {
                    strSend += " ";
                }
                List<byte> bufsend = new List<byte>();//填充到临时表中

                for (int i = 0; i < strSend.Length; i++)
                {
                    bufsend.Add(Convert.ToByte(strSend.Substring(i * 2, 2), 16));

                    //string sendinfo = "";
                    //bufsend.Add(Convert.ToByte(sendTxt.Text ));
                }
                if (isCRCorNot == 1)
                {
                    CRCArry = CRC16_C(bufsend.ToArray());

                    bufsend.Add(CRCArry[0]);
                    bufsend.Add(CRCArry[1]);
                }
                //转换列表为数组后发送
                serialPort.Write(bufsend.ToArray(), 0, bufsend.Count);
            }
        }

        #region**需要修改**
        //开始采集数据
        private bool StartOrNot;
        private void StartSendRecBto_Click(object sender, EventArgs e)
        {
            //if (serialPort.IsOpen)
            //{
            //    Closing = true;
            //    StartOrNot = true;


            //    StartSendRecBto.Text = "Close";

            //    while (StartSendRecBto.Text == "Close")
            //    {

            //        if (StartOrNot)
            //        {
            //            orderSend(sendTxt.Text, 1);
            //            serialPort.DataReceived += dataReceived;
            //            System.Threading.Thread.Sleep(50);





            //            break;

            //        }
            //    }
            //    StartOrNot = false;
            //    StartSendRecBto.Text = "Open";

            //    return;

            //}
            //else
            //{
            //    MessageBox.Show("串口未连接", "Error");
            //    return;
            //}



        }

        #endregion

        //自动发送选择
        private void AutoSendCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoSendCheckBox.Checked)
            {
                this.AutoSendTimer.Enabled = true;

                try
                {
                    this.AutoSendTimer.Interval = int.Parse(SendIntervalTimetbx.Text);
                    SendIntervalTimetbx.Enabled = false;
                    //sendTxt.ReadOnly = true;
                    sendBto.Enabled = false;
                }
                catch
                {
                    this.AutoSendTimer.Interval = 1000;

                }
            }
            else
            {
                this.AutoSendTimer.Enabled = false;
                SendIntervalTimetbx.Enabled = true;
               // sendTxt.ReadOnly = false;
                sendBto.Enabled = true;
            }
        }
        //private void AutoSendRadioBto_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (AutoSendRadioBto.Checked)
        //    {
        //        this. AutoSendTimer.Enabled = true;

        //        AutoSendTimer.Start();

        //        SendIntervalTimetbx.Enabled = false;
        //        sendTxt.ReadOnly = true;
        //        sendBto.Enabled = false;
        //    }
        //    else
        //    {
        //        AutoSendTimer.Enabled = false;
        //        AutoSendTimer.Stop();

        //        SendIntervalTimetbx.Enabled = true;
        //        sendTxt.ReadOnly = false;
        //        sendBto.Enabled = true;
        //    }
        //}
        private void AutoSendTimer_Tick(object sender, EventArgs e)
        {
            sendBto.PerformClick();
        }



        private void sendBto_Click(object sender, EventArgs e)
        {
            string Send_Text = sendTxt.Text;
            if (OpenCloseBto.Text == "Close")
            {
                if (Send_Text == null || Send_Text == "")
                {
                    MessageBox.Show("请输入发送内容", "Error");
                    return;
                }
                else
                {
                    if (RS485CheckBox.Checked)
                    {
                        Send_RS485();
                    }
                    else
                    {
                        if (sendStrRadiobto.Checked)
                        {
                            serialPort.WriteLine(Send_Text);//发送一行指令
                        }
                        else
                        {
                            char[] values = Send_Text.ToCharArray();
                            foreach (char letter in values)
                            {
                                int value = Convert.ToInt32(letter);
                                string HexInput = String.Format("{0:X}", value);
                                serialPort.WriteLine(HexInput);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("串口未打开", "Error");
                AutoSendCheckBox.Enabled = false;
                return;
            }


        }
        //RS485发送
        public void Send_RS485()
        {
            byte[] sendbuf = new byte[sendTxt.Text.Length / 2];

            for(int i=0;i<sendbuf.Length; i++)
            {
                try
                {
                    sendbuf[i] = byte.Parse(sendTxt.Text.Substring(i * 2, 2),System.Globalization.NumberStyles.HexNumber);
                }
                catch
                {
                    throw new ArgumentException("数据缓存失败", "error");
                }
            }
                
          
        }

        //closing
        private void Mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
            if (saveDataFS != null)
            {
                saveDataFS.Close();
                saveDataFS = null;
            }
        }

        //refresh
        private void refreshBto_Click(object sender, EventArgs e)
        {
            PortNameCbb.Text = "";
            PortNameCbb.Items.Clear();

            string[] new_name = SerialPort.GetPortNames();
            if (new_name == null)
            {
                MessageBox.Show("没有发现新串口", "Error");
                return;
            }
            foreach (string s in new_name)
            {
                PortNameCbb.Items.Add(s);
            }

            PortNameCbb.SelectedIndex = 0;
            BaudRateCbb.SelectedIndex = 0;
            DataBitsCbb.SelectedIndex = 0;
            StopBitsCbb.SelectedIndex = 0;
            ParityCbb.SelectedIndex = 0;

        }

        //CRC校验
        public byte[] CRC16_C(byte[] data)
        {
            byte CRC16Low;
            byte CRC16High;
            byte CL;
            byte CH;
            byte[] tmpData;
            byte SaveHigh;byte Savelow;
            int I;
            int Flag;
            CRC16High =0XFF;
            CRC16Low =0xFF;
            CL = 0x01;
            CH = 0xA0;
            tmpData = data;

            for(int i=0;i<tmpData.Length;i++)
            {
                CRC16Low = (byte)(CRC16Low ^ tmpData[i]);
                for(Flag =0;Flag<=13;Flag++)
                {
                    SaveHigh = CRC16High;
                    Savelow = CRC16Low;
                    CRC16High = (byte)(CRC16High >> 1);//高位右移一位
                    CRC16Low = (byte)(CRC16Low >> 1);//低位右移一位
                    if((SaveHigh&0x01)==0x01)
                    {
                        CRC16Low = (byte)(CRC16Low | 0 & 80);//如果高字节最后一位是1，则低位字节右移后前面补1
                    }
                    if((Savelow&0x01)==0x01)
                    {
                        CRC16High = (byte)(CRC16High ^ CH);
                        CRC16Low = (byte)(CRC16Low ^ CL);
                    }

                }
            }

            byte[] ReturnData = new byte[2];

           
            ReturnData[0] = CRC16High;       //CRC高位
            ReturnData[1] = CRC16Low;       //CRC低位
            return ReturnData;
        }


        #region **clear**
        //clear
        private void ClearBto_Value_Click(object sender, EventArgs e)
        {
            Max_allowed.Text = "";
            Min_allowed.Text = "";
        }

        private void ClearReceivedText_Click(object sender, EventArgs e)
        {
            receiveTxt.Text = "";
        }

        private void ClearSendTxt_Click(object sender, EventArgs e)
        {
            sendTxt.Text = "";
        }

        #endregion



        #region **save**
        //保存数据
        private void Save_Data_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog_received = new SaveFileDialog();
            saveFileDialog_received.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog_received.Filter = "txt file|*txt";
            saveFileDialog_received.DefaultExt = ".txt";
            saveFileDialog_received.FileName = "received data";

            if (saveFileDialog_received.ShowDialog() == DialogResult.OK)
            {
                string Fname_received = saveFileDialog_received.FileName;
                System.IO.File.WriteAllText(Fname_received, receiveTxt.Text);
            }
        }

        private void Save_pressure_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog_pressure = new SaveFileDialog();
            saveFileDialog_pressure.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveFileDialog_pressure.Filter = "txt file|*txt";
            saveFileDialog_pressure.DefaultExt = ".txt";
            saveFileDialog_pressure.FileName = "pressure";

            if (saveFileDialog_pressure.ShowDialog() == DialogResult.OK)
            {
                string Fname_pressure = saveFileDialog_pressure.FileName;
                System.IO.File.WriteAllText(Fname_pressure, pressureTxt.Text);
            }
        }
        #endregion

        //设置阈值大小
        private void MaxOkBto_Value_Click(object sender, EventArgs e)

        {

            Double Max_Value = Convert.ToDouble(Max_allowed.Text);
            Double Min_Value = Convert.ToDouble(Min_allowed.Text);

            if ((Max_Value > 0 && Max_Value <= 1.6) && (Min_Value >= 0 && Min_Value < 1.6) && (Max_Value > Min_Value))
            {
                MessageBox.Show("保存成功");
            }
            else
            {
                MessageBox.Show("设置无效，请再次检查输入的阈值大小！");
                return;
            }

        }



        #region**计算压力**
        //计算压力大小
        //private void pressure_calculation()
        //{
        //    try
        //    {
        //        if (receiveTxt.Text.Length == 10)
        //        {
        //            string received_Data = receiveTxt.Text;
        //            string Output_final;
        //            string[] Data_Info = received_Data.Split(new char[] { ' ' });
        //            string xiaoshu = Data_Info[0];
        //            string yali_high = Data_Info[1];
        //            string yali_low = Data_Info[2];
        //            string unit = Data_Info[3];
        //            string unit_output = "";
        //            switch (unit)
        //            {
        //                case "3": unit_output = "kPa"; break;
        //                case "4": unit_output = "Mpa"; break;
        //                case "5": unit_output = "Pa"; break;

        //            }

        //            if (received_Data == null)
        //            {
        //                MessageBox.Show("没有接收到数据", "Error");
        //                return;
        //            }
        //            else
        //            {

        //                try
        //                {
        //                    //16进制换成10进制-xiaoshu
        //                    double  xiaoshu_shu = Convert .ToDouble(xiaoshu);
        //                    double  xiaoshu_output = Math.Pow(10, xiaoshu_shu);
        //                    //16进制换成10进制-压力高位
        //                    int yali_high_output = Convert.ToInt32 (yali_high);
        //                    //16进制换成10进制-压力低位,
        //                    int yali_low_output = Convert.ToInt32(yali_low);
        //                    long int pressure_output=yali_high_output

        //                    //判断数值的正确性
        //                    if (yali_high_output <= 99999 && yali_high_output >= 0 && yali_low_output <= 99999 && yali_low_output >= 0)
        //                    {
        //                        Output_final = Convert.ToString((yali_high_output  + yali_low_output) / xiaoshu_output);

        //                        //输出压力值
        //                        pressureTxt.Text += DateTime.Now + ": " + Output_final + unit_output + "\r\n";

        //                        pressureTxt.SelectionStart = pressureTxt.Text.Length;
        //                        pressureTxt.ScrollToCaret();
        //                        serialPort.DiscardInBuffer();
        //                    }

        //                }
        //                catch (System.Exception ex)
        //                {
        //                    MessageBox.Show(ex.Message, "Error");
        //                }
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        MessageBox.Show("数据不完整", "Error");
        //        return;
        //    }
        #endregion
    }




}



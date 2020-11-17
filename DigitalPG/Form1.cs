using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using NLog;

namespace DigitalPG
{
    public partial class Form1 : Form
    {
        private ILogger logger = LogManager.GetCurrentClassLogger();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var port = new SerialPort("COM5",2400);
            port.DataReceived += Port_DataReceived;
            try
            {
                port.Open();
                logger.Debug("打开端口");
            }
            catch (Exception ex)
            {
                logger.Debug(ex);
            }
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            SerialPort port = (SerialPort)sender;

            int bytes = port.BytesToRead;
            byte[] buffer = new byte[bytes];

            if (port.BytesToRead > 1)
            {

                port.Read(buffer, 0, bytes);
            }

            var result   = "";
            foreach (byte item in buffer)
            {
                result+=" "+item;
            }
            string hex = BitConverter.ToString(buffer).Replace("-", string.Empty);


            logger.Debug(hex);
        }
    }
    
}

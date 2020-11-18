namespace 压力监控系统_初版
{
    partial class Mainform
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.refreshBto = new System.Windows.Forms.Button();
            this.ParityLab = new System.Windows.Forms.Label();
            this.StopBitsLab = new System.Windows.Forms.Label();
            this.DataBitsLab = new System.Windows.Forms.Label();
            this.BaudRateLabel = new System.Windows.Forms.Label();
            this.PortNameLabel = new System.Windows.Forms.Label();
            this.ParityCbb = new System.Windows.Forms.ComboBox();
            this.StopBitsCbb = new System.Windows.Forms.ComboBox();
            this.DataBitsCbb = new System.Windows.Forms.ComboBox();
            this.BaudRateCbb = new System.Windows.Forms.ComboBox();
            this.PortNameCbb = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ClearBto_Value = new System.Windows.Forms.Button();
            this.MaxOkBto_Value = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Min_allowed = new System.Windows.Forms.TextBox();
            this.Max_allowed = new System.Windows.Forms.TextBox();
            this.pressureTxt = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Save_pressure = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.AutoSendCheckBox = new System.Windows.Forms.CheckBox();
            this.cbRs485 = new System.Windows.Forms.CheckBox();
            this.StartSendRecBto = new System.Windows.Forms.Button();
            this.ClearSendTxt = new System.Windows.Forms.Button();
            this.ClearReceivedText = new System.Windows.Forms.Button();
            this.Save_Data = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SendIntervalTimetbx = new System.Windows.Forms.TextBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sendStrRadiobto = new System.Windows.Forms.RadioButton();
            this.receiveTxt = new System.Windows.Forms.TextBox();
            this.recStrRadBto = new System.Windows.Forms.RadioButton();
            this.waittime = new System.Windows.Forms.Timer(this.components);
            this.AutoSendTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.refreshBto);
            this.groupBox1.Controls.Add(this.ParityLab);
            this.groupBox1.Controls.Add(this.StopBitsLab);
            this.groupBox1.Controls.Add(this.DataBitsLab);
            this.groupBox1.Controls.Add(this.BaudRateLabel);
            this.groupBox1.Controls.Add(this.PortNameLabel);
            this.groupBox1.Controls.Add(this.ParityCbb);
            this.groupBox1.Controls.Add(this.StopBitsCbb);
            this.groupBox1.Controls.Add(this.DataBitsCbb);
            this.groupBox1.Controls.Add(this.BaudRateCbb);
            this.groupBox1.Controls.Add(this.PortNameCbb);
            this.groupBox1.Location = new System.Drawing.Point(14, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(226, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = " ";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(134, 208);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(66, 33);
            this.btnOpen.TabIndex = 29;
            this.btnOpen.Text = "Open\r\n";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.OpenCloseBto_Click);
            // 
            // refreshBto
            // 
            this.refreshBto.Location = new System.Drawing.Point(12, 208);
            this.refreshBto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.refreshBto.Name = "refreshBto";
            this.refreshBto.Size = new System.Drawing.Size(66, 33);
            this.refreshBto.TabIndex = 28;
            this.refreshBto.Text = "Refresh";
            this.refreshBto.UseVisualStyleBackColor = true;
            this.refreshBto.Click += new System.EventHandler(this.refreshBto_Click);
            // 
            // ParityLab
            // 
            this.ParityLab.AutoSize = true;
            this.ParityLab.Location = new System.Drawing.Point(15, 173);
            this.ParityLab.Name = "ParityLab";
            this.ParityLab.Size = new System.Drawing.Size(43, 17);
            this.ParityLab.TabIndex = 27;
            this.ParityLab.Text = "Parity:";
            // 
            // StopBitsLab
            // 
            this.StopBitsLab.AutoSize = true;
            this.StopBitsLab.Location = new System.Drawing.Point(15, 136);
            this.StopBitsLab.Name = "StopBitsLab";
            this.StopBitsLab.Size = new System.Drawing.Size(63, 17);
            this.StopBitsLab.TabIndex = 26;
            this.StopBitsLab.Text = "Stop Bits:";
            // 
            // DataBitsLab
            // 
            this.DataBitsLab.AutoSize = true;
            this.DataBitsLab.Location = new System.Drawing.Point(15, 99);
            this.DataBitsLab.Name = "DataBitsLab";
            this.DataBitsLab.Size = new System.Drawing.Size(63, 17);
            this.DataBitsLab.TabIndex = 25;
            this.DataBitsLab.Text = "Data Bits:";
            // 
            // BaudRateLabel
            // 
            this.BaudRateLabel.AutoSize = true;
            this.BaudRateLabel.Location = new System.Drawing.Point(15, 61);
            this.BaudRateLabel.Name = "BaudRateLabel";
            this.BaudRateLabel.Size = new System.Drawing.Size(71, 17);
            this.BaudRateLabel.TabIndex = 24;
            this.BaudRateLabel.Text = "Baud Rate:";
            // 
            // PortNameLabel
            // 
            this.PortNameLabel.AutoSize = true;
            this.PortNameLabel.Location = new System.Drawing.Point(15, 24);
            this.PortNameLabel.Name = "PortNameLabel";
            this.PortNameLabel.Size = new System.Drawing.Size(74, 17);
            this.PortNameLabel.TabIndex = 23;
            this.PortNameLabel.Text = "Port Name:";
            // 
            // ParityCbb
            // 
            this.ParityCbb.FormattingEnabled = true;
            this.ParityCbb.Location = new System.Drawing.Point(95, 169);
            this.ParityCbb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ParityCbb.Name = "ParityCbb";
            this.ParityCbb.Size = new System.Drawing.Size(105, 25);
            this.ParityCbb.TabIndex = 22;
            // 
            // StopBitsCbb
            // 
            this.StopBitsCbb.FormattingEnabled = true;
            this.StopBitsCbb.Location = new System.Drawing.Point(95, 132);
            this.StopBitsCbb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StopBitsCbb.Name = "StopBitsCbb";
            this.StopBitsCbb.Size = new System.Drawing.Size(105, 25);
            this.StopBitsCbb.TabIndex = 21;
            // 
            // DataBitsCbb
            // 
            this.DataBitsCbb.FormattingEnabled = true;
            this.DataBitsCbb.Location = new System.Drawing.Point(95, 95);
            this.DataBitsCbb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataBitsCbb.Name = "DataBitsCbb";
            this.DataBitsCbb.Size = new System.Drawing.Size(105, 25);
            this.DataBitsCbb.TabIndex = 20;
            // 
            // BaudRateCbb
            // 
            this.BaudRateCbb.FormattingEnabled = true;
            this.BaudRateCbb.Location = new System.Drawing.Point(95, 58);
            this.BaudRateCbb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BaudRateCbb.Name = "BaudRateCbb";
            this.BaudRateCbb.Size = new System.Drawing.Size(105, 25);
            this.BaudRateCbb.TabIndex = 19;
            // 
            // PortNameCbb
            // 
            this.PortNameCbb.FormattingEnabled = true;
            this.PortNameCbb.Location = new System.Drawing.Point(95, 21);
            this.PortNameCbb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PortNameCbb.Name = "PortNameCbb";
            this.PortNameCbb.Size = new System.Drawing.Size(105, 25);
            this.PortNameCbb.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ClearBto_Value);
            this.groupBox2.Controls.Add(this.MaxOkBto_Value);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Min_allowed);
            this.groupBox2.Controls.Add(this.Max_allowed);
            this.groupBox2.Location = new System.Drawing.Point(814, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(299, 201);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Limit Setup";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ClearBto_Value
            // 
            this.ClearBto_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearBto_Value.Location = new System.Drawing.Point(199, 141);
            this.ClearBto_Value.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearBto_Value.Name = "ClearBto_Value";
            this.ClearBto_Value.Size = new System.Drawing.Size(66, 33);
            this.ClearBto_Value.TabIndex = 5;
            this.ClearBto_Value.Text = "Clear";
            this.ClearBto_Value.UseVisualStyleBackColor = true;
            this.ClearBto_Value.Click += new System.EventHandler(this.ClearBto_Value_Click);
            // 
            // MaxOkBto_Value
            // 
            this.MaxOkBto_Value.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxOkBto_Value.Location = new System.Drawing.Point(94, 141);
            this.MaxOkBto_Value.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaxOkBto_Value.Name = "MaxOkBto_Value";
            this.MaxOkBto_Value.Size = new System.Drawing.Size(66, 33);
            this.MaxOkBto_Value.TabIndex = 4;
            this.MaxOkBto_Value.Text = "Save";
            this.MaxOkBto_Value.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Min. Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Max. Value";
            // 
            // Min_allowed
            // 
            this.Min_allowed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Min_allowed.Location = new System.Drawing.Point(104, 98);
            this.Min_allowed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Min_allowed.Name = "Min_allowed";
            this.Min_allowed.Size = new System.Drawing.Size(171, 23);
            this.Min_allowed.TabIndex = 1;
            // 
            // Max_allowed
            // 
            this.Max_allowed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Max_allowed.Location = new System.Drawing.Point(104, 50);
            this.Max_allowed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Max_allowed.Name = "Max_allowed";
            this.Max_allowed.Size = new System.Drawing.Size(171, 23);
            this.Max_allowed.TabIndex = 0;
            // 
            // pressureTxt
            // 
            this.pressureTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pressureTxt.Location = new System.Drawing.Point(12, 30);
            this.pressureTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pressureTxt.Multiline = true;
            this.pressureTxt.Name = "pressureTxt";
            this.pressureTxt.Size = new System.Drawing.Size(201, 158);
            this.pressureTxt.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.Save_pressure);
            this.groupBox3.Controls.Add(this.pressureTxt);
            this.groupBox3.Location = new System.Drawing.Point(14, 286);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(226, 250);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Received:";
            // 
            // Save_pressure
            // 
            this.Save_pressure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_pressure.Location = new System.Drawing.Point(147, 196);
            this.Save_pressure.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Save_pressure.Name = "Save_pressure";
            this.Save_pressure.Size = new System.Drawing.Size(66, 33);
            this.Save_pressure.TabIndex = 19;
            this.Save_pressure.Text = "Save";
            this.Save_pressure.UseVisualStyleBackColor = true;
            this.Save_pressure.Click += new System.EventHandler(this.Save_pressure_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1138, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslabel
            // 
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(74, 17);
            this.statuslabel.Text = "StatusLabel";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.AutoSendCheckBox);
            this.groupBox4.Controls.Add(this.cbRs485);
            this.groupBox4.Controls.Add(this.StartSendRecBto);
            this.groupBox4.Controls.Add(this.ClearSendTxt);
            this.groupBox4.Controls.Add(this.ClearReceivedText);
            this.groupBox4.Controls.Add(this.Save_Data);
            this.groupBox4.Controls.Add(this.btnSend);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.SendIntervalTimetbx);
            this.groupBox4.Controls.Add(this.txtSend);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.sendStrRadiobto);
            this.groupBox4.Controls.Add(this.receiveTxt);
            this.groupBox4.Controls.Add(this.recStrRadBto);
            this.groupBox4.Location = new System.Drawing.Point(246, 13);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(562, 519);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data Region";
            // 
            // AutoSendCheckBox
            // 
            this.AutoSendCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AutoSendCheckBox.AutoSize = true;
            this.AutoSendCheckBox.Location = new System.Drawing.Point(135, 419);
            this.AutoSendCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AutoSendCheckBox.Name = "AutoSendCheckBox";
            this.AutoSendCheckBox.Size = new System.Drawing.Size(83, 21);
            this.AutoSendCheckBox.TabIndex = 32;
            this.AutoSendCheckBox.Text = "AutoSend";
            this.AutoSendCheckBox.UseVisualStyleBackColor = true;
            this.AutoSendCheckBox.CheckedChanged += new System.EventHandler(this.AutoSendCheckBox_CheckedChanged);
            // 
            // cbRs485
            // 
            this.cbRs485.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbRs485.AutoSize = true;
            this.cbRs485.Location = new System.Drawing.Point(191, 203);
            this.cbRs485.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbRs485.Name = "cbRs485";
            this.cbRs485.Size = new System.Drawing.Size(63, 21);
            this.cbRs485.TabIndex = 31;
            this.cbRs485.Text = "RS485";
            this.cbRs485.UseVisualStyleBackColor = true;
            // 
            // StartSendRecBto
            // 
            this.StartSendRecBto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartSendRecBto.Location = new System.Drawing.Point(31, 412);
            this.StartSendRecBto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartSendRecBto.Name = "StartSendRecBto";
            this.StartSendRecBto.Size = new System.Drawing.Size(78, 33);
            this.StartSendRecBto.TabIndex = 28;
            this.StartSendRecBto.Text = "Open";
            this.StartSendRecBto.UseVisualStyleBackColor = true;
            this.StartSendRecBto.Click += new System.EventHandler(this.StartSendRecBto_Click);
            // 
            // ClearSendTxt
            // 
            this.ClearSendTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearSendTxt.Location = new System.Drawing.Point(96, 196);
            this.ClearSendTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearSendTxt.Name = "ClearSendTxt";
            this.ClearSendTxt.Size = new System.Drawing.Size(66, 33);
            this.ClearSendTxt.TabIndex = 27;
            this.ClearSendTxt.Text = "Clear";
            this.ClearSendTxt.UseVisualStyleBackColor = true;
            this.ClearSendTxt.Click += new System.EventHandler(this.ClearSendTxt_Click);
            // 
            // ClearReceivedText
            // 
            this.ClearReceivedText.Location = new System.Drawing.Point(101, 24);
            this.ClearReceivedText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearReceivedText.Name = "ClearReceivedText";
            this.ClearReceivedText.Size = new System.Drawing.Size(66, 33);
            this.ClearReceivedText.TabIndex = 26;
            this.ClearReceivedText.Text = "Clear";
            this.ClearReceivedText.UseVisualStyleBackColor = true;
            this.ClearReceivedText.Click += new System.EventHandler(this.ClearReceivedText_Click);
            // 
            // Save_Data
            // 
            this.Save_Data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Save_Data.Location = new System.Drawing.Point(479, 412);
            this.Save_Data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Save_Data.Name = "Save_Data";
            this.Save_Data.Size = new System.Drawing.Size(66, 33);
            this.Save_Data.TabIndex = 25;
            this.Save_Data.Text = "Save";
            this.Save_Data.UseVisualStyleBackColor = true;
            this.Save_Data.Click += new System.EventHandler(this.Save_Data_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSend.BackColor = System.Drawing.Color.LightGreen;
            this.btnSend.Location = new System.Drawing.Point(396, 412);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(66, 33);
            this.btnSend.TabIndex = 24;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.sendBto_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "ms";
            // 
            // SendIntervalTimetbx
            // 
            this.SendIntervalTimetbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SendIntervalTimetbx.Location = new System.Drawing.Point(261, 412);
            this.SendIntervalTimetbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SendIntervalTimetbx.Multiline = true;
            this.SendIntervalTimetbx.Name = "SendIntervalTimetbx";
            this.SendIntervalTimetbx.Size = new System.Drawing.Size(66, 33);
            this.SendIntervalTimetbx.TabIndex = 22;
            // 
            // txtSend
            // 
            this.txtSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSend.Location = new System.Drawing.Point(24, 237);
            this.txtSend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(521, 148);
            this.txtSend.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Sended:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Received:";
            // 
            // sendStrRadiobto
            // 
            this.sendStrRadiobto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sendStrRadiobto.AutoSize = true;
            this.sendStrRadiobto.Location = new System.Drawing.Point(273, 203);
            this.sendStrRadiobto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendStrRadiobto.Name = "sendStrRadiobto";
            this.sendStrRadiobto.Size = new System.Drawing.Size(60, 21);
            this.sendStrRadiobto.TabIndex = 17;
            this.sendStrRadiobto.TabStop = true;
            this.sendStrRadiobto.Text = "String";
            this.sendStrRadiobto.UseVisualStyleBackColor = true;
            // 
            // receiveTxt
            // 
            this.receiveTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.receiveTxt.Location = new System.Drawing.Point(24, 62);
            this.receiveTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.receiveTxt.Multiline = true;
            this.receiveTxt.Name = "receiveTxt";
            this.receiveTxt.ReadOnly = true;
            this.receiveTxt.Size = new System.Drawing.Size(521, 124);
            this.receiveTxt.TabIndex = 14;
            // 
            // recStrRadBto
            // 
            this.recStrRadBto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.recStrRadBto.AutoSize = true;
            this.recStrRadBto.Location = new System.Drawing.Point(436, -186);
            this.recStrRadBto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recStrRadBto.Name = "recStrRadBto";
            this.recStrRadBto.Size = new System.Drawing.Size(60, 21);
            this.recStrRadBto.TabIndex = 16;
            this.recStrRadBto.TabStop = true;
            this.recStrRadBto.Text = "String";
            this.recStrRadBto.UseVisualStyleBackColor = true;
            // 
            // AutoSendTimer
            // 
            this.AutoSendTimer.Interval = 1000;
            this.AutoSendTimer.Tick += new System.EventHandler(this.AutoSendTimer_Tick);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 562);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1176, 824);
            this.Name = "Mainform";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mainform_FormClosing);
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button refreshBto;
        private System.Windows.Forms.Label ParityLab;
        private System.Windows.Forms.Label StopBitsLab;
        private System.Windows.Forms.Label DataBitsLab;
        private System.Windows.Forms.Label BaudRateLabel;
        private System.Windows.Forms.Label PortNameLabel;
        private System.Windows.Forms.ComboBox ParityCbb;
        private System.Windows.Forms.ComboBox StopBitsCbb;
        private System.Windows.Forms.ComboBox DataBitsCbb;
        private System.Windows.Forms.ComboBox BaudRateCbb;
        private System.Windows.Forms.ComboBox PortNameCbb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ClearBto_Value;
        private System.Windows.Forms.Button MaxOkBto_Value;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Min_allowed;
        private System.Windows.Forms.TextBox Max_allowed;
        private System.Windows.Forms.TextBox pressureTxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Save_pressure;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statuslabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton sendStrRadiobto;
        private System.Windows.Forms.TextBox receiveTxt;
        private System.Windows.Forms.RadioButton recStrRadBto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SendIntervalTimetbx;
        private System.Windows.Forms.Button Save_Data;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button ClearSendTxt;
        private System.Windows.Forms.Button ClearReceivedText;
        private System.Windows.Forms.Timer waittime;
        private System.Windows.Forms.Button StartSendRecBto;
        private System.Windows.Forms.Timer AutoSendTimer;
        private System.Windows.Forms.CheckBox cbRs485;
        private System.Windows.Forms.CheckBox AutoSendCheckBox;
    }
}


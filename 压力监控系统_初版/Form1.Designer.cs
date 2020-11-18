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
            this.RS485CheckBox = new System.Windows.Forms.CheckBox();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 31;
            this.label3.Text = " ";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(99, 182);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 29;
            this.btnOpen.Text = "Open\r\n";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.OpenCloseBto_Click);
            // 
            // refreshBto
            // 
            this.refreshBto.Location = new System.Drawing.Point(14, 182);
            this.refreshBto.Name = "refreshBto";
            this.refreshBto.Size = new System.Drawing.Size(75, 23);
            this.refreshBto.TabIndex = 28;
            this.refreshBto.Text = "Refresh";
            this.refreshBto.UseVisualStyleBackColor = true;
            this.refreshBto.Click += new System.EventHandler(this.refreshBto_Click);
            // 
            // ParityLab
            // 
            this.ParityLab.AutoSize = true;
            this.ParityLab.Location = new System.Drawing.Point(16, 145);
            this.ParityLab.Name = "ParityLab";
            this.ParityLab.Size = new System.Drawing.Size(41, 12);
            this.ParityLab.TabIndex = 27;
            this.ParityLab.Text = "Parity";
            // 
            // StopBitsLab
            // 
            this.StopBitsLab.AutoSize = true;
            this.StopBitsLab.Location = new System.Drawing.Point(16, 113);
            this.StopBitsLab.Name = "StopBitsLab";
            this.StopBitsLab.Size = new System.Drawing.Size(65, 12);
            this.StopBitsLab.TabIndex = 26;
            this.StopBitsLab.Text = "Stop Bits:";
            // 
            // DataBitsLab
            // 
            this.DataBitsLab.AutoSize = true;
            this.DataBitsLab.Location = new System.Drawing.Point(16, 81);
            this.DataBitsLab.Name = "DataBitsLab";
            this.DataBitsLab.Size = new System.Drawing.Size(65, 12);
            this.DataBitsLab.TabIndex = 25;
            this.DataBitsLab.Text = "Data Bits:";
            // 
            // BaudRateLabel
            // 
            this.BaudRateLabel.AutoSize = true;
            this.BaudRateLabel.Location = new System.Drawing.Point(16, 49);
            this.BaudRateLabel.Name = "BaudRateLabel";
            this.BaudRateLabel.Size = new System.Drawing.Size(65, 12);
            this.BaudRateLabel.TabIndex = 24;
            this.BaudRateLabel.Text = "Baud Rate:";
            // 
            // PortNameLabel
            // 
            this.PortNameLabel.AutoSize = true;
            this.PortNameLabel.Location = new System.Drawing.Point(16, 17);
            this.PortNameLabel.Name = "PortNameLabel";
            this.PortNameLabel.Size = new System.Drawing.Size(65, 12);
            this.PortNameLabel.TabIndex = 23;
            this.PortNameLabel.Text = "Port Name:";
            // 
            // ParityCbb
            // 
            this.ParityCbb.FormattingEnabled = true;
            this.ParityCbb.Location = new System.Drawing.Point(81, 142);
            this.ParityCbb.Name = "ParityCbb";
            this.ParityCbb.Size = new System.Drawing.Size(91, 20);
            this.ParityCbb.TabIndex = 22;
            // 
            // StopBitsCbb
            // 
            this.StopBitsCbb.FormattingEnabled = true;
            this.StopBitsCbb.Location = new System.Drawing.Point(81, 110);
            this.StopBitsCbb.Name = "StopBitsCbb";
            this.StopBitsCbb.Size = new System.Drawing.Size(91, 20);
            this.StopBitsCbb.TabIndex = 21;
            // 
            // DataBitsCbb
            // 
            this.DataBitsCbb.FormattingEnabled = true;
            this.DataBitsCbb.Location = new System.Drawing.Point(81, 78);
            this.DataBitsCbb.Name = "DataBitsCbb";
            this.DataBitsCbb.Size = new System.Drawing.Size(91, 20);
            this.DataBitsCbb.TabIndex = 20;
            // 
            // BaudRateCbb
            // 
            this.BaudRateCbb.FormattingEnabled = true;
            this.BaudRateCbb.Location = new System.Drawing.Point(81, 46);
            this.BaudRateCbb.Name = "BaudRateCbb";
            this.BaudRateCbb.Size = new System.Drawing.Size(91, 20);
            this.BaudRateCbb.TabIndex = 19;
            // 
            // PortNameCbb
            // 
            this.PortNameCbb.FormattingEnabled = true;
            this.PortNameCbb.Location = new System.Drawing.Point(81, 14);
            this.PortNameCbb.Name = "PortNameCbb";
            this.PortNameCbb.Size = new System.Drawing.Size(91, 20);
            this.PortNameCbb.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ClearBto_Value);
            this.groupBox2.Controls.Add(this.MaxOkBto_Value);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Min_allowed);
            this.groupBox2.Controls.Add(this.Max_allowed);
            this.groupBox2.Location = new System.Drawing.Point(717, 303);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 150);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Limit Setup";
            // 
            // ClearBto_Value
            // 
            this.ClearBto_Value.Location = new System.Drawing.Point(99, 110);
            this.ClearBto_Value.Name = "ClearBto_Value";
            this.ClearBto_Value.Size = new System.Drawing.Size(73, 20);
            this.ClearBto_Value.TabIndex = 5;
            this.ClearBto_Value.Text = "Clear";
            this.ClearBto_Value.UseVisualStyleBackColor = true;
            this.ClearBto_Value.Click += new System.EventHandler(this.ClearBto_Value_Click);
            // 
            // MaxOkBto_Value
            // 
            this.MaxOkBto_Value.Location = new System.Drawing.Point(14, 110);
            this.MaxOkBto_Value.Name = "MaxOkBto_Value";
            this.MaxOkBto_Value.Size = new System.Drawing.Size(75, 20);
            this.MaxOkBto_Value.TabIndex = 4;
            this.MaxOkBto_Value.Text = "Save";
            this.MaxOkBto_Value.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "Min. Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Max. Value";
            // 
            // Min_allowed
            // 
            this.Min_allowed.Location = new System.Drawing.Point(89, 69);
            this.Min_allowed.Name = "Min_allowed";
            this.Min_allowed.Size = new System.Drawing.Size(85, 21);
            this.Min_allowed.TabIndex = 1;
            // 
            // Max_allowed
            // 
            this.Max_allowed.Location = new System.Drawing.Point(89, 35);
            this.Max_allowed.Name = "Max_allowed";
            this.Max_allowed.Size = new System.Drawing.Size(85, 21);
            this.Max_allowed.TabIndex = 0;
            // 
            // pressureTxt
            // 
            this.pressureTxt.Location = new System.Drawing.Point(6, 20);
            this.pressureTxt.Multiline = true;
            this.pressureTxt.Name = "pressureTxt";
            this.pressureTxt.Size = new System.Drawing.Size(173, 149);
            this.pressureTxt.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Save_pressure);
            this.groupBox3.Controls.Add(this.pressureTxt);
            this.groupBox3.Location = new System.Drawing.Point(12, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 205);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Received:";
            // 
            // Save_pressure
            // 
            this.Save_pressure.Location = new System.Drawing.Point(105, 175);
            this.Save_pressure.Name = "Save_pressure";
            this.Save_pressure.Size = new System.Drawing.Size(74, 21);
            this.Save_pressure.TabIndex = 19;
            this.Save_pressure.Text = "Save";
            this.Save_pressure.UseVisualStyleBackColor = true;
            this.Save_pressure.Click += new System.EventHandler(this.Save_pressure_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 599);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(987, 22);
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
            this.groupBox4.Controls.Add(this.AutoSendCheckBox);
            this.groupBox4.Controls.Add(this.RS485CheckBox);
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
            this.groupBox4.Location = new System.Drawing.Point(222, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(468, 362);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // AutoSendCheckBox
            // 
            this.AutoSendCheckBox.AutoSize = true;
            this.AutoSendCheckBox.Location = new System.Drawing.Point(118, 320);
            this.AutoSendCheckBox.Name = "AutoSendCheckBox";
            this.AutoSendCheckBox.Size = new System.Drawing.Size(72, 16);
            this.AutoSendCheckBox.TabIndex = 32;
            this.AutoSendCheckBox.Text = "AutoSend";
            this.AutoSendCheckBox.UseVisualStyleBackColor = true;
            this.AutoSendCheckBox.CheckedChanged += new System.EventHandler(this.AutoSendCheckBox_CheckedChanged);
            // 
            // RS485CheckBox
            // 
            this.RS485CheckBox.AutoSize = true;
            this.RS485CheckBox.Location = new System.Drawing.Point(156, 156);
            this.RS485CheckBox.Name = "RS485CheckBox";
            this.RS485CheckBox.Size = new System.Drawing.Size(54, 16);
            this.RS485CheckBox.TabIndex = 31;
            this.RS485CheckBox.Text = "RS485";
            this.RS485CheckBox.UseVisualStyleBackColor = true;
            // 
            // StartSendRecBto
            // 
            this.StartSendRecBto.Location = new System.Drawing.Point(30, 320);
            this.StartSendRecBto.Name = "StartSendRecBto";
            this.StartSendRecBto.Size = new System.Drawing.Size(75, 23);
            this.StartSendRecBto.TabIndex = 28;
            this.StartSendRecBto.Text = "Open";
            this.StartSendRecBto.UseVisualStyleBackColor = true;
            this.StartSendRecBto.Click += new System.EventHandler(this.StartSendRecBto_Click);
            // 
            // ClearSendTxt
            // 
            this.ClearSendTxt.Location = new System.Drawing.Point(74, 153);
            this.ClearSendTxt.Name = "ClearSendTxt";
            this.ClearSendTxt.Size = new System.Drawing.Size(67, 23);
            this.ClearSendTxt.TabIndex = 27;
            this.ClearSendTxt.Text = "Clear";
            this.ClearSendTxt.UseVisualStyleBackColor = true;
            this.ClearSendTxt.Click += new System.EventHandler(this.ClearSendTxt_Click);
            // 
            // ClearReceivedText
            // 
            this.ClearReceivedText.Location = new System.Drawing.Point(87, 17);
            this.ClearReceivedText.Name = "ClearReceivedText";
            this.ClearReceivedText.Size = new System.Drawing.Size(67, 23);
            this.ClearReceivedText.TabIndex = 26;
            this.ClearReceivedText.Text = "Clear";
            this.ClearReceivedText.UseVisualStyleBackColor = true;
            this.ClearReceivedText.Click += new System.EventHandler(this.ClearReceivedText_Click);
            // 
            // Save_Data
            // 
            this.Save_Data.Location = new System.Drawing.Point(217, 282);
            this.Save_Data.Name = "Save_Data";
            this.Save_Data.Size = new System.Drawing.Size(66, 19);
            this.Save_Data.TabIndex = 25;
            this.Save_Data.Text = "Save";
            this.Save_Data.UseVisualStyleBackColor = true;
            this.Save_Data.Click += new System.EventHandler(this.Save_Data_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(118, 284);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(67, 19);
            this.btnSend.TabIndex = 24;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.sendBto_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "ms";
            // 
            // SendIntervalTimetbx
            // 
            this.SendIntervalTimetbx.Location = new System.Drawing.Point(30, 282);
            this.SendIntervalTimetbx.Name = "SendIntervalTimetbx";
            this.SendIntervalTimetbx.Size = new System.Drawing.Size(43, 21);
            this.SendIntervalTimetbx.TabIndex = 22;
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(21, 182);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(393, 87);
            this.txtSend.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "Sended:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "Received:";
            // 
            // sendStrRadiobto
            // 
            this.sendStrRadiobto.AutoSize = true;
            this.sendStrRadiobto.Location = new System.Drawing.Point(226, 156);
            this.sendStrRadiobto.Name = "sendStrRadiobto";
            this.sendStrRadiobto.Size = new System.Drawing.Size(59, 16);
            this.sendStrRadiobto.TabIndex = 17;
            this.sendStrRadiobto.TabStop = true;
            this.sendStrRadiobto.Text = "String";
            this.sendStrRadiobto.UseVisualStyleBackColor = true;
            // 
            // receiveTxt
            // 
            this.receiveTxt.Location = new System.Drawing.Point(21, 44);
            this.receiveTxt.Multiline = true;
            this.receiveTxt.Name = "receiveTxt";
            this.receiveTxt.ReadOnly = true;
            this.receiveTxt.Size = new System.Drawing.Size(393, 103);
            this.receiveTxt.TabIndex = 14;
            // 
            // recStrRadBto
            // 
            this.recStrRadBto.AutoSize = true;
            this.recStrRadBto.Location = new System.Drawing.Point(224, 22);
            this.recStrRadBto.Name = "recStrRadBto";
            this.recStrRadBto.Size = new System.Drawing.Size(59, 16);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 621);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.CheckBox RS485CheckBox;
        private System.Windows.Forms.CheckBox AutoSendCheckBox;
    }
}


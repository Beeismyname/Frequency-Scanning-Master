namespace FR
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl_SerialPortMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_RxCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_TxCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_SystemTimeDisplay = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_Parity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_StopBits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_DataBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_BaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_PortName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_DisplayTime = new System.Windows.Forms.CheckBox();
            this.cb_DisplaySend = new System.Windows.Forms.CheckBox();
            this.cb_AutoLine = new System.Windows.Forms.CheckBox();
            this.rb_ReceviedASII = new System.Windows.Forms.RadioButton();
            this.rb_ReceviedHex = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rb_SendASII = new System.Windows.Forms.RadioButton();
            this.rb_SendHex = new System.Windows.Forms.RadioButton();
            this.tsb_NewSerialPort = new System.Windows.Forms.ToolStripButton();
            this.tsb_Open = new System.Windows.Forms.ToolStripButton();
            this.tsb_Save = new System.Windows.Forms.ToolStripButton();
            this.tsb_Logo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Add = new System.Windows.Forms.ToolStripButton();
            this.tsb_Sub = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Play = new System.Windows.Forms.ToolStripButton();
            this.tsb_Stop = new System.Windows.Forms.ToolStripButton();
            this.stb_Clear = new System.Windows.Forms.ToolStripButton();
            this.tsb_windwon = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Setting = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Send_Frequency = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Step_Number = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Sweep_Step = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.End_Frequency = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Start_Frequency = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Creat_Sine = new System.Windows.Forms.Button();
            this.Send_Data = new System.ComponentModel.BackgroundWorker();
            this.Receive_Data = new System.ComponentModel.BackgroundWorker();
            this.Save_Data = new System.Windows.Forms.Button();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.Draw = new System.ComponentModel.BackgroundWorker();
            this.plotView2 = new OxyPlot.WindowsForms.PlotView();
            this.plotView3 = new OxyPlot.WindowsForms.PlotView();
            this.m_Input = new System.Windows.Forms.ComboBox();
            this.m_Output = new System.Windows.Forms.ComboBox();
            this.M_IO = new System.Windows.Forms.GroupBox();
            this.magnific = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.M_IO.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_SerialPortMessage,
            this.tssl_RxCounter,
            this.tssl_TxCounter,
            this.tssl_SystemTimeDisplay});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 638);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1532, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl_SerialPortMessage
            // 
            this.tssl_SerialPortMessage.AutoSize = false;
            this.tssl_SerialPortMessage.Name = "tssl_SerialPortMessage";
            this.tssl_SerialPortMessage.Size = new System.Drawing.Size(230, 20);
            this.tssl_SerialPortMessage.Text = "串口信息";
            // 
            // tssl_RxCounter
            // 
            this.tssl_RxCounter.AutoSize = false;
            this.tssl_RxCounter.Name = "tssl_RxCounter";
            this.tssl_RxCounter.Size = new System.Drawing.Size(150, 20);
            this.tssl_RxCounter.Text = "RX:0 Byte";
            // 
            // tssl_TxCounter
            // 
            this.tssl_TxCounter.AutoSize = false;
            this.tssl_TxCounter.Name = "tssl_TxCounter";
            this.tssl_TxCounter.Size = new System.Drawing.Size(150, 20);
            this.tssl_TxCounter.Text = "TX:0 Byte";
            // 
            // tssl_SystemTimeDisplay
            // 
            this.tssl_SystemTimeDisplay.AutoSize = false;
            this.tssl_SystemTimeDisplay.Name = "tssl_SystemTimeDisplay";
            this.tssl_SystemTimeDisplay.Size = new System.Drawing.Size(167, 20);
            this.tssl_SystemTimeDisplay.Text = "时间";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1532, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.文件ToolStripMenuItem.Text = "文件(F)";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.编辑ToolStripMenuItem.Text = "编辑(E)";
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.视图ToolStripMenuItem.Text = "视图(V)";
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.工具ToolStripMenuItem.Text = "工具(T)";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.帮助ToolStripMenuItem.Text = "帮助(H)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_Parity);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbb_StopBits);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbb_DataBits);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbb_BaudRate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbb_PortName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(195, 175);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口参数";
            // 
            // cbb_Parity
            // 
            this.cbb_Parity.FormattingEnabled = true;
            this.cbb_Parity.Location = new System.Drawing.Point(68, 144);
            this.cbb_Parity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_Parity.Name = "cbb_Parity";
            this.cbb_Parity.Size = new System.Drawing.Size(121, 23);
            this.cbb_Parity.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "校验位";
            // 
            // cbb_StopBits
            // 
            this.cbb_StopBits.FormattingEnabled = true;
            this.cbb_StopBits.Location = new System.Drawing.Point(67, 115);
            this.cbb_StopBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_StopBits.Name = "cbb_StopBits";
            this.cbb_StopBits.Size = new System.Drawing.Size(121, 23);
            this.cbb_StopBits.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "停止位";
            // 
            // cbb_DataBits
            // 
            this.cbb_DataBits.FormattingEnabled = true;
            this.cbb_DataBits.Location = new System.Drawing.Point(68, 86);
            this.cbb_DataBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_DataBits.Name = "cbb_DataBits";
            this.cbb_DataBits.Size = new System.Drawing.Size(121, 23);
            this.cbb_DataBits.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "数据位";
            // 
            // cbb_BaudRate
            // 
            this.cbb_BaudRate.FormattingEnabled = true;
            this.cbb_BaudRate.Location = new System.Drawing.Point(67, 58);
            this.cbb_BaudRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_BaudRate.Name = "cbb_BaudRate";
            this.cbb_BaudRate.Size = new System.Drawing.Size(121, 23);
            this.cbb_BaudRate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "波特率";
            // 
            // cbb_PortName
            // 
            this.cbb_PortName.FormattingEnabled = true;
            this.cbb_PortName.Location = new System.Drawing.Point(67, 28);
            this.cbb_PortName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_PortName.Name = "cbb_PortName";
            this.cbb_PortName.Size = new System.Drawing.Size(121, 23);
            this.cbb_PortName.TabIndex = 1;
            this.cbb_PortName.DropDown += new System.EventHandler(this.cbb_PortName_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_DisplayTime);
            this.groupBox2.Controls.Add(this.cb_DisplaySend);
            this.groupBox2.Controls.Add(this.cb_AutoLine);
            this.groupBox2.Controls.Add(this.rb_ReceviedASII);
            this.groupBox2.Controls.Add(this.rb_ReceviedHex);
            this.groupBox2.Location = new System.Drawing.Point(8, 271);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(195, 140);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收";
            // 
            // cb_DisplayTime
            // 
            this.cb_DisplayTime.AutoSize = true;
            this.cb_DisplayTime.Location = new System.Drawing.Point(21, 108);
            this.cb_DisplayTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_DisplayTime.Name = "cb_DisplayTime";
            this.cb_DisplayTime.Size = new System.Drawing.Size(89, 19);
            this.cb_DisplayTime.TabIndex = 1;
            this.cb_DisplayTime.Text = "显示时间";
            this.cb_DisplayTime.UseVisualStyleBackColor = true;
            // 
            // cb_DisplaySend
            // 
            this.cb_DisplaySend.AutoSize = true;
            this.cb_DisplaySend.Location = new System.Drawing.Point(21, 82);
            this.cb_DisplaySend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_DisplaySend.Name = "cb_DisplaySend";
            this.cb_DisplaySend.Size = new System.Drawing.Size(89, 19);
            this.cb_DisplaySend.TabIndex = 1;
            this.cb_DisplaySend.Text = "显示发送";
            this.cb_DisplaySend.UseVisualStyleBackColor = true;
            // 
            // cb_AutoLine
            // 
            this.cb_AutoLine.AutoSize = true;
            this.cb_AutoLine.Location = new System.Drawing.Point(21, 58);
            this.cb_AutoLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_AutoLine.Name = "cb_AutoLine";
            this.cb_AutoLine.Size = new System.Drawing.Size(89, 19);
            this.cb_AutoLine.TabIndex = 1;
            this.cb_AutoLine.Text = "自动换行";
            this.cb_AutoLine.UseVisualStyleBackColor = true;
            // 
            // rb_ReceviedASII
            // 
            this.rb_ReceviedASII.AutoSize = true;
            this.rb_ReceviedASII.Location = new System.Drawing.Point(101, 24);
            this.rb_ReceviedASII.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_ReceviedASII.Name = "rb_ReceviedASII";
            this.rb_ReceviedASII.Size = new System.Drawing.Size(60, 19);
            this.rb_ReceviedASII.TabIndex = 0;
            this.rb_ReceviedASII.TabStop = true;
            this.rb_ReceviedASII.Text = "ASII";
            this.rb_ReceviedASII.UseVisualStyleBackColor = true;
            // 
            // rb_ReceviedHex
            // 
            this.rb_ReceviedHex.AutoSize = true;
            this.rb_ReceviedHex.Location = new System.Drawing.Point(21, 24);
            this.rb_ReceviedHex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_ReceviedHex.Name = "rb_ReceviedHex";
            this.rb_ReceviedHex.Size = new System.Drawing.Size(52, 19);
            this.rb_ReceviedHex.TabIndex = 0;
            this.rb_ReceviedHex.TabStop = true;
            this.rb_ReceviedHex.Text = "HEX";
            this.rb_ReceviedHex.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.rb_SendASII);
            this.groupBox3.Controls.Add(this.rb_SendHex);
            this.groupBox3.Location = new System.Drawing.Point(8, 418);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(195, 99);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(5, 59);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(89, 19);
            this.checkBox4.TabIndex = 1;
            this.checkBox4.Text = "重复发送";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "ms";
            // 
            // rb_SendASII
            // 
            this.rb_SendASII.AutoSize = true;
            this.rb_SendASII.Checked = true;
            this.rb_SendASII.Location = new System.Drawing.Point(101, 24);
            this.rb_SendASII.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_SendASII.Name = "rb_SendASII";
            this.rb_SendASII.Size = new System.Drawing.Size(60, 19);
            this.rb_SendASII.TabIndex = 0;
            this.rb_SendASII.TabStop = true;
            this.rb_SendASII.Text = "ASII";
            this.rb_SendASII.UseVisualStyleBackColor = true;
            // 
            // rb_SendHex
            // 
            this.rb_SendHex.AutoSize = true;
            this.rb_SendHex.Location = new System.Drawing.Point(21, 24);
            this.rb_SendHex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_SendHex.Name = "rb_SendHex";
            this.rb_SendHex.Size = new System.Drawing.Size(52, 19);
            this.rb_SendHex.TabIndex = 0;
            this.rb_SendHex.Text = "HEX";
            this.rb_SendHex.UseVisualStyleBackColor = true;
            // 
            // tsb_NewSerialPort
            // 
            this.tsb_NewSerialPort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_NewSerialPort.Image = ((System.Drawing.Image)(resources.GetObject("tsb_NewSerialPort.Image")));
            this.tsb_NewSerialPort.ImageTransparentColor = System.Drawing.Color.White;
            this.tsb_NewSerialPort.Name = "tsb_NewSerialPort";
            this.tsb_NewSerialPort.Size = new System.Drawing.Size(40, 40);
            this.tsb_NewSerialPort.Text = "toolStripButton1";
            // 
            // tsb_Open
            // 
            this.tsb_Open.AutoSize = false;
            this.tsb_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Open.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Open.Image")));
            this.tsb_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Open.Name = "tsb_Open";
            this.tsb_Open.Size = new System.Drawing.Size(40, 40);
            this.tsb_Open.Text = "toolStripButton1";
            // 
            // tsb_Save
            // 
            this.tsb_Save.AutoSize = false;
            this.tsb_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Save.Image = global::FR.Properties.Resources.dakai;
            this.tsb_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Save.Name = "tsb_Save";
            this.tsb_Save.Size = new System.Drawing.Size(40, 40);
            this.tsb_Save.Text = "toolStripButton1";
            // 
            // tsb_Logo
            // 
            this.tsb_Logo.AutoSize = false;
            this.tsb_Logo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Logo.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Logo.Image")));
            this.tsb_Logo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Logo.Name = "tsb_Logo";
            this.tsb_Logo.Size = new System.Drawing.Size(40, 40);
            this.tsb_Logo.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // tsb_Add
            // 
            this.tsb_Add.AutoSize = false;
            this.tsb_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Add.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Add.Image")));
            this.tsb_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Add.Name = "tsb_Add";
            this.tsb_Add.Size = new System.Drawing.Size(40, 40);
            this.tsb_Add.Text = "toolStripButton1";
            // 
            // tsb_Sub
            // 
            this.tsb_Sub.AutoSize = false;
            this.tsb_Sub.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Sub.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Sub.Image")));
            this.tsb_Sub.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Sub.Name = "tsb_Sub";
            this.tsb_Sub.Size = new System.Drawing.Size(40, 40);
            this.tsb_Sub.Text = "toolStripButton1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 43);
            // 
            // tsb_Play
            // 
            this.tsb_Play.AutoSize = false;
            this.tsb_Play.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Play.Image = global::FR.Properties.Resources.bofang;
            this.tsb_Play.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Play.Name = "tsb_Play";
            this.tsb_Play.Size = new System.Drawing.Size(40, 40);
            this.tsb_Play.Text = "toolStripButton1";
            this.tsb_Play.Click += new System.EventHandler(this.tsb_Play_Click);
            // 
            // tsb_Stop
            // 
            this.tsb_Stop.AutoSize = false;
            this.tsb_Stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Stop.Image = global::FR.Properties.Resources.ai08;
            this.tsb_Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Stop.Name = "tsb_Stop";
            this.tsb_Stop.Size = new System.Drawing.Size(40, 40);
            this.tsb_Stop.Text = "toolStripButton1";
            this.tsb_Stop.Click += new System.EventHandler(this.tsb_Stop_Click);
            // 
            // stb_Clear
            // 
            this.stb_Clear.AutoSize = false;
            this.stb_Clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stb_Clear.Image = global::FR.Properties.Resources.qingchu;
            this.stb_Clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stb_Clear.Name = "stb_Clear";
            this.stb_Clear.Size = new System.Drawing.Size(40, 40);
            this.stb_Clear.Text = "toolStripButton1";
            this.stb_Clear.Click += new System.EventHandler(this.stb_Clear_Click);
            // 
            // tsb_windwon
            // 
            this.tsb_windwon.AutoSize = false;
            this.tsb_windwon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_windwon.Image = global::FR.Properties.Resources.chuangti;
            this.tsb_windwon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_windwon.Name = "tsb_windwon";
            this.tsb_windwon.Size = new System.Drawing.Size(40, 40);
            this.tsb_windwon.Text = "toolStripButton1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // tsb_Setting
            // 
            this.tsb_Setting.AutoSize = false;
            this.tsb_Setting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Setting.Image = global::FR.Properties.Resources.quanjushezhi;
            this.tsb_Setting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Setting.Name = "tsb_Setting";
            this.tsb_Setting.Size = new System.Drawing.Size(40, 40);
            this.tsb_Setting.Text = "toolStripButton1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_NewSerialPort,
            this.tsb_Open,
            this.tsb_Save,
            this.tsb_Logo,
            this.toolStripSeparator1,
            this.tsb_Add,
            this.tsb_Sub,
            this.toolStripSeparator3,
            this.tsb_Play,
            this.tsb_Stop,
            this.stb_Clear,
            this.tsb_windwon,
            this.toolStripSeparator2,
            this.tsb_Setting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1532, 43);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Send_Frequency);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.Step_Number);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.Sweep_Step);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.End_Frequency);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.Start_Frequency);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(243, 92);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(236, 173);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "正弦信号参数";
            // 
            // Send_Frequency
            // 
            this.Send_Frequency.FormattingEnabled = true;
            this.Send_Frequency.Items.AddRange(new object[] {
            "1000"});
            this.Send_Frequency.Location = new System.Drawing.Point(94, 144);
            this.Send_Frequency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Send_Frequency.Name = "Send_Frequency";
            this.Send_Frequency.Size = new System.Drawing.Size(121, 23);
            this.Send_Frequency.TabIndex = 1;
            this.Send_Frequency.Text = "1000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "发送频率";
            // 
            // Step_Number
            // 
            this.Step_Number.FormattingEnabled = true;
            this.Step_Number.Items.AddRange(new object[] {
            "1000"});
            this.Step_Number.Location = new System.Drawing.Point(94, 115);
            this.Step_Number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Step_Number.Name = "Step_Number";
            this.Step_Number.Size = new System.Drawing.Size(121, 23);
            this.Step_Number.TabIndex = 1;
            this.Step_Number.Text = "2000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "每步样本数";
            // 
            // Sweep_Step
            // 
            this.Sweep_Step.FormattingEnabled = true;
            this.Sweep_Step.Items.AddRange(new object[] {
            "512"});
            this.Sweep_Step.Location = new System.Drawing.Point(94, 86);
            this.Sweep_Step.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sweep_Step.Name = "Sweep_Step";
            this.Sweep_Step.Size = new System.Drawing.Size(121, 23);
            this.Sweep_Step.TabIndex = 1;
            this.Sweep_Step.Text = "20";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "扫频步数";
            // 
            // End_Frequency
            // 
            this.End_Frequency.FormattingEnabled = true;
            this.End_Frequency.Items.AddRange(new object[] {
            "1000"});
            this.End_Frequency.Location = new System.Drawing.Point(94, 55);
            this.End_Frequency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.End_Frequency.Name = "End_Frequency";
            this.End_Frequency.Size = new System.Drawing.Size(121, 23);
            this.End_Frequency.TabIndex = 1;
            this.End_Frequency.Text = "10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "终止频率";
            // 
            // Start_Frequency
            // 
            this.Start_Frequency.FormattingEnabled = true;
            this.Start_Frequency.Items.AddRange(new object[] {
            "0.1"});
            this.Start_Frequency.Location = new System.Drawing.Point(94, 28);
            this.Start_Frequency.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Start_Frequency.Name = "Start_Frequency";
            this.Start_Frequency.Size = new System.Drawing.Size(121, 23);
            this.Start_Frequency.TabIndex = 1;
            this.Start_Frequency.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "起始频率";
            // 
            // Creat_Sine
            // 
            this.Creat_Sine.Location = new System.Drawing.Point(243, 270);
            this.Creat_Sine.Name = "Creat_Sine";
            this.Creat_Sine.Size = new System.Drawing.Size(215, 43);
            this.Creat_Sine.TabIndex = 8;
            this.Creat_Sine.Text = "开始扫频";
            this.Creat_Sine.UseVisualStyleBackColor = true;
            this.Creat_Sine.Click += new System.EventHandler(this.Creat_Sine_Click);
            // 
            // Send_Data
            // 
            this.Send_Data.WorkerReportsProgress = true;
            this.Send_Data.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Send_Data_DoWork);
            // 
            // Receive_Data
            // 
            this.Receive_Data.WorkerSupportsCancellation = true;
            this.Receive_Data.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Receive_Data_DoWork);
            // 
            // Save_Data
            // 
            this.Save_Data.Location = new System.Drawing.Point(243, 328);
            this.Save_Data.Name = "Save_Data";
            this.Save_Data.Size = new System.Drawing.Size(215, 43);
            this.Save_Data.TabIndex = 9;
            this.Save_Data.Text = "保存数据";
            this.Save_Data.UseVisualStyleBackColor = true;
            this.Save_Data.Click += new System.EventHandler(this.Save_Data_Click);
            // 
            // plotView1
            // 
            this.plotView1.Location = new System.Drawing.Point(209, 386);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(575, 249);
            this.plotView1.TabIndex = 10;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Draw
            // 
            this.Draw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Draw_DoWork);
            // 
            // plotView2
            // 
            this.plotView2.Location = new System.Drawing.Point(811, 74);
            this.plotView2.Name = "plotView2";
            this.plotView2.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView2.Size = new System.Drawing.Size(640, 274);
            this.plotView2.TabIndex = 11;
            this.plotView2.Text = "plotView2";
            this.plotView2.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView2.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView2.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plotView3
            // 
            this.plotView3.Location = new System.Drawing.Point(811, 354);
            this.plotView3.Name = "plotView3";
            this.plotView3.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView3.Size = new System.Drawing.Size(640, 281);
            this.plotView3.TabIndex = 12;
            this.plotView3.Text = "plotView3";
            this.plotView3.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView3.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView3.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // m_Input
            // 
            this.m_Input.FormattingEnabled = true;
            this.m_Input.Items.AddRange(new object[] {
            "0.0000003"});
            this.m_Input.Location = new System.Drawing.Point(20, 57);
            this.m_Input.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_Input.Name = "m_Input";
            this.m_Input.Size = new System.Drawing.Size(121, 23);
            this.m_Input.TabIndex = 2;
            this.m_Input.Text = "0.0000003";
            // 
            // m_Output
            // 
            this.m_Output.FormattingEnabled = true;
            this.m_Output.Items.AddRange(new object[] {
            "0.00001"});
            this.m_Output.Location = new System.Drawing.Point(20, 138);
            this.m_Output.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_Output.Name = "m_Output";
            this.m_Output.Size = new System.Drawing.Size(121, 23);
            this.m_Output.TabIndex = 3;
            this.m_Output.Text = "0.00001";
            // 
            // M_IO
            // 
            this.M_IO.Controls.Add(this.magnific);
            this.M_IO.Controls.Add(this.label14);
            this.M_IO.Controls.Add(this.label13);
            this.M_IO.Controls.Add(this.label12);
            this.M_IO.Controls.Add(this.m_Input);
            this.M_IO.Controls.Add(this.m_Output);
            this.M_IO.Location = new System.Drawing.Point(513, 92);
            this.M_IO.Name = "M_IO";
            this.M_IO.Size = new System.Drawing.Size(168, 256);
            this.M_IO.TabIndex = 13;
            this.M_IO.TabStop = false;
            this.M_IO.Text = "输入输出幅值";
            // 
            // magnific
            // 
            this.magnific.FormattingEnabled = true;
            this.magnific.Items.AddRange(new object[] {
            "1"});
            this.magnific.Location = new System.Drawing.Point(20, 219);
            this.magnific.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.magnific.Name = "magnific";
            this.magnific.Size = new System.Drawing.Size(121, 23);
            this.magnific.TabIndex = 7;
            this.magnific.Text = "1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 15);
            this.label14.TabIndex = 6;
            this.label14.Text = "输出显示放大倍数";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 5;
            this.label13.Text = "输出幅值";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "输入幅值";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 664);
            this.Controls.Add(this.M_IO);
            this.Controls.Add(this.plotView3);
            this.Controls.Add(this.plotView2);
            this.Controls.Add(this.plotView1);
            this.Controls.Add(this.Save_Data);
            this.Controls.Add(this.Creat_Sine);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "扫频串口2.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.M_IO.ResumeLayout(false);
            this.M_IO.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_PortName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_Parity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_StopBits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_DataBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_BaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel tssl_TxCounter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_DisplayTime;
        private System.Windows.Forms.CheckBox cb_DisplaySend;
        private System.Windows.Forms.CheckBox cb_AutoLine;
        private System.Windows.Forms.RadioButton rb_ReceviedASII;
        private System.Windows.Forms.RadioButton rb_ReceviedHex;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rb_SendASII;
        private System.Windows.Forms.RadioButton rb_SendHex;
        private System.Windows.Forms.ToolStripStatusLabel tssl_SerialPortMessage;
        private System.Windows.Forms.ToolStripStatusLabel tssl_RxCounter;
        private System.Windows.Forms.ToolStripStatusLabel tssl_SystemTimeDisplay;
        private System.Windows.Forms.ToolStripButton tsb_NewSerialPort;
        private System.Windows.Forms.ToolStripButton tsb_Open;
        private System.Windows.Forms.ToolStripButton tsb_Save;
        private System.Windows.Forms.ToolStripButton tsb_Logo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb_Add;
        private System.Windows.Forms.ToolStripButton tsb_Sub;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsb_Play;
        private System.Windows.Forms.ToolStripButton tsb_Stop;
        private System.Windows.Forms.ToolStripButton stb_Clear;
        private System.Windows.Forms.ToolStripButton tsb_windwon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsb_Setting;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox Send_Frequency;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Step_Number;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Sweep_Step;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox End_Frequency;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Start_Frequency;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Creat_Sine;
        private System.ComponentModel.BackgroundWorker Send_Data;
        private System.ComponentModel.BackgroundWorker Receive_Data;
        private System.Windows.Forms.Button Save_Data;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.ComponentModel.BackgroundWorker Draw;
        private OxyPlot.WindowsForms.PlotView plotView2;
        private OxyPlot.WindowsForms.PlotView plotView3;
        private System.Windows.Forms.ComboBox m_Input;
        private System.Windows.Forms.ComboBox m_Output;
        private System.Windows.Forms.GroupBox M_IO;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox magnific;
        private System.Windows.Forms.Label label14;
    }
}


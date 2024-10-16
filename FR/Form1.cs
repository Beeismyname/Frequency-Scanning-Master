using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot;
using MathNet.Numerics.IntegralTransforms;
using System.Collections.Generic;

namespace FR
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //设置状态条居右显示
            statusStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            tssl_SystemTimeDisplay.Alignment = ToolStripItemAlignment.Right;
            originalFormWidth = this.Width;
            originalFormHeight = this.Height;
            // 保存每个控件的初始位置和大小
            originalControlBounds = new Dictionary<Control, Rectangle>();
            foreach (Control control in this.Controls)
            {
                originalControlBounds[control] = control.Bounds;
            }

            // 监听窗体的 Resize 事件
            this.Resize += Form1_Resize;
            // 订阅 FormClosing 事件
            this.FormClosing += Form1_FormClosing;
        }

        /// <summary>
        /// 窗体加载初始化相关参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplaySystemTime();
            SeralPortComboboxInit();
            SerialPortSelecte();
            SetPlot1();
            SetPlot2();
            SetPlot3();
            //4、绑定委托
            //  serialDataReceived = SerialPortDisplay;
        }

        #region 设置画板大小
        private void SetPlot1() {
            _myPlotModel = new PlotModel()
            {
                //Title = "tklsa",
                LegendTitle = "Legend",
                LegendOrientation = LegendOrientation.Horizontal,
                LegendPlacement = LegendPlacement.Outside,
                LegendPosition = OxyPlot.LegendPosition.RightTop,
                LegendBackground = OxyColor.FromAColor(100, OxyColors.Beige),
                LegendBorder = OxyColors.Black,
                //DefaultFont = "微软雅黑",
            };
            //X轴
            _dateAxis = new LinearAxis()
            {
                Position = OxyPlot.Axes.AxisPosition.Bottom,
                MajorGridlineStyle = OxyPlot.LineStyle.Solid,
                MinorGridlineStyle = OxyPlot.LineStyle.Dot,
                IntervalLength = 80,
                Angle = 0,
                IsZoomEnabled = false,
                IsPanEnabled = false,
                Maximum = 200,
                Minimum = 0,

            };
            _myPlotModel.Axes.Add(_dateAxis);

            //Y轴
            _valueAxis = new LinearAxis()
            {
                Position = OxyPlot.Axes.AxisPosition.Left,
                MajorGridlineStyle = OxyPlot.LineStyle.Solid,
                MinorGridlineStyle = OxyPlot.LineStyle.Dot,
                IntervalLength = 80,
                Angle = 0,
                IsZoomEnabled = false,
                IsPanEnabled = false,
                Maximum = 1,
                Minimum = -1,

                Title = ""
            };
            _myPlotModel.Axes.Add(_valueAxis);

            //添加两条曲线
            var series = new LineSeries()
            {
                Color = OxyColors.Green,
                StrokeThickness = 1,
                MarkerSize = 1,
                MarkerStroke = OxyColors.DarkGreen,
                MarkerType = MarkerType.Diamond,
                Title = "InPut",
                Smooth = true
            };
            _myPlotModel.Series.Add(series);
            series = new LineSeries()
            {
                Color = OxyColors.Blue,
                StrokeThickness = 1,
                MarkerSize = 1,
                MarkerStroke = OxyColors.BlueViolet,
                MarkerType = MarkerType.Star,
                Title = "OutPut",
                Smooth = true
            };
            _myPlotModel.Series.Add(series);


            plotView1.Model = _myPlotModel;
        }

        private void SetPlot2()
        {
            _LogPlotMode = new PlotModel()
            {
                //Title = "tklsa",
                LegendTitle = "Legend",
                LegendOrientation = LegendOrientation.Horizontal,
                LegendPlacement = LegendPlacement.Outside,
                LegendPosition = OxyPlot.LegendPosition.RightTop,
                LegendBackground = OxyColor.FromAColor(100, OxyColors.Beige),
                LegendBorder = OxyColors.Black,
                //DefaultFont = "微软雅黑",
            };
            //X轴
            _LogAxis = new LogarithmicAxis()
            {
                Position = OxyPlot.Axes.AxisPosition.Bottom,
                MajorGridlineStyle = OxyPlot.LineStyle.Solid,
                MinorGridlineStyle = OxyPlot.LineStyle.Dot,
                IntervalLength = 80,
                Angle = 0,
                IsZoomEnabled = false,
                IsPanEnabled = false,
                Maximum = 1010,
                Minimum = 0,
                              
            };
            _LogPlotMode.Axes.Add(_LogAxis);

            //Y轴
            _LogValueAxis = new LinearAxis()
            {
                Position = OxyPlot.Axes.AxisPosition.Left,
                MajorGridlineStyle = OxyPlot.LineStyle.Solid,
                MinorGridlineStyle = OxyPlot.LineStyle.Dot,
                IntervalLength = 80,
                Angle = 0,
                IsZoomEnabled = false,
                IsPanEnabled = false,
                Maximum = 10,
                Minimum = -80,
                Title = ""
            };
            _LogPlotMode.Axes.Add(_LogValueAxis);

            //添加条曲线
            var series = new LineSeries()
            {
                Color = OxyColors.Green,
                StrokeThickness = 1,
                MarkerSize = 1,
                MarkerStroke = OxyColors.DarkGreen,
                MarkerType = MarkerType.Diamond,
                Title = "Amp",
                Smooth = true
            };
            _LogPlotMode.Series.Add(series);

            plotView2.Model = _LogPlotMode;
        }

        private void SetPlot3()
        {
            _PLogPlotMode = new PlotModel()
            {
                //Title = "tklsa",
                LegendTitle = "Legend",
                LegendOrientation = LegendOrientation.Horizontal,
                LegendPlacement = LegendPlacement.Outside,
                LegendPosition = OxyPlot.LegendPosition.RightTop,
                LegendBackground = OxyColor.FromAColor(100, OxyColors.Beige),
                LegendBorder = OxyColors.Black,
                //DefaultFont = "微软雅黑",
            };
            //X轴
            _PLogAxis = new LogarithmicAxis()
            {
                Position = OxyPlot.Axes.AxisPosition.Bottom,
                MajorGridlineStyle = OxyPlot.LineStyle.Solid,
                MinorGridlineStyle = OxyPlot.LineStyle.Dot,
                IntervalLength = 80,
                Angle = 0,
                IsZoomEnabled = false,
                IsPanEnabled = false,
                Maximum = 1010,
                Minimum = 0,

            };
            _PLogPlotMode.Axes.Add(_PLogAxis);

            //Y轴
            _PLogValueAxis = new LinearAxis()
            {
                Position = OxyPlot.Axes.AxisPosition.Left,
                MajorGridlineStyle = OxyPlot.LineStyle.Solid,
                MinorGridlineStyle = OxyPlot.LineStyle.Dot,
                IntervalLength = 80,
                Angle = 0,
                IsZoomEnabled = false,
                IsPanEnabled = false,
                //Maximum = 10,
                //Minimum = -80,
                Title = ""
            };
            _PLogPlotMode.Axes.Add(_PLogValueAxis);

            //添加条曲线
            var series = new LineSeries()
            {
                Color = OxyColors.Green,
                StrokeThickness = 1,
                MarkerSize = 1,
                MarkerStroke = OxyColors.DarkGreen,
                MarkerType = MarkerType.Diamond,
                Title = "Pha",    
                Smooth = true
            };
            _PLogPlotMode.Series.Add(series);

            plotView3.Model = _PLogPlotMode;
        }
        #endregion

        #region  解码
        private double Data_Handel(byte[] Receivebyte)
        {
            double Rceeive_value = 0;
            byte Check;
            Check = (byte)(Receivebyte[1] + Receivebyte[2] + Receivebyte[3] + Receivebyte[4]);
            if (Receivebyte[0] == 0xAA && Check == Receivebyte[5])
            {
                if ((Receivebyte[2] & 0x40) != 0x40)
                {
                    Rceeive_value = ((Receivebyte[2] << 16) + (Receivebyte[3] << 8) + (Receivebyte[4]));
                    
                }
                else
                {                  
                    Rceeive_value = -1 * (((Receivebyte[2] ^ 0x40) << 16) + (Receivebyte[3] << 8) + (Receivebyte[4]));
                }
            }
            return Rceeive_value;
        }

        #endregion

        #region USdelay定时器

        [DllImport("kernel32.dll")]
        extern static short QueryPerformanceCounter(ref long x);
        [DllImport("kernel32.dll")]
        extern static short QueryPerformanceFrequency(ref long x);
        public void USdelay(long delay_Time)
        {
            long stop_Value = 0;
            long start_Value = 0;
            long freq = 0;
            long n = 0;

            QueryPerformanceFrequency(ref freq);  //获取CPU频率
            long count = delay_Time * freq / 1000;   //这里写成1000000就是微秒，写成1000就是毫秒
            QueryPerformanceCounter(ref start_Value); //获取初始前值

            while (n < count) //不能精确判定
            {
                QueryPerformanceCounter(ref stop_Value);//获取终止变量值
                n = stop_Value - start_Value;
            }
        }

        #endregion

        #region delayUs定时器

        /*
        功能：微秒延时（1000us == 1ms）
        参数：延时时间单位ms
        延时5us：delayUs(0.005)；
        */
        public static double delayUs(double timer)
        {
            System.Diagnostics.Stopwatch stopTime = new System.Diagnostics.Stopwatch();
            double time = timer*0.001;
            stopTime.Start();
            while (stopTime.Elapsed.TotalMilliseconds < time) { }
            stopTime.Stop();

            return stopTime.Elapsed.TotalMilliseconds;
        }


        #endregion

        #region 全局字段(变量)
        //实例化串口
        SerialPort serialPort = new SerialPort();//初始化串口实例
        public static class GlobalData
        {
            // 静态字段，用于存储共享数据           
            public static double[,] Sine_Signal;
            public static double[,] Receive_Signal;
            public static double[,] S_Frequency;

            public static byte[,][] Receivebytes;
            public static byte[,][] Sendbytes;
            //定义监视实时发送频率 
            public static int NumFrequency = 0;
            //正弦扫频频率
            
            public static int Sendnum = 0;
            public static int NumFrequency_1;
            public static int Sweep_Flag = 0;
            public static int ReadCompletionFlag = 2;               
            public static int Samples_PerStep;
            public static int Num_Step;
        }
        //发送数据保存至全局变量，Send_Data线程调用
        //ulong[,] Send_Signal;
        //正弦信号数据保存
        //public Int64[,] Sine_Signal;
        //接收数据保存至全局变量数组

        //接收数据保存至全局变量，Receive_Data线程调用
        //byte[] Receivebytes = new byte[0];
        //
        private PlotModel _LogPlotMode;
        private LogarithmicAxis _LogAxis;//X轴
        private LinearAxis _LogValueAxis;//Y轴

        private PlotModel _myPlotModel;
        private LinearAxis _dateAxis;//X轴
        private LinearAxis _valueAxis;//Y轴

        private PlotModel _PLogPlotMode;
        private LogarithmicAxis _PLogAxis;//X轴
        private LinearAxis _PLogValueAxis;//Y轴

        private float originalFormWidth;
        private float originalFormHeight;
        private Dictionary<Control, Rectangle> originalControlBounds;

        double M_Input, M_Output, O_Magnific;
        //发送计数
        int PlotBode = 0;
        //延时全局变量单位us
        int Delay=1000;
        //接收计数                                        
        int RxCounter = 0;
        //发送计数
        int TxCounter = 0;
       
        #endregion

        #region 定时器显示系统时间
        /// <summary>
        /// 初始化定时器，Tick事件显示系统时间
        /// </summary>
        private void DisplaySystemTime()
        {
            Timer sysTimeView = new Timer();//定时器实例初始化
            sysTimeView.Interval = 1000;//引发Tick事件的时间毫秒
            sysTimeView.Tick += SysTimeView_Tick;//
            sysTimeView.Start();//定时器启用
        }
        /// <summary>
        /// 显示系统时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SysTimeView_Tick(object sender, EventArgs e)
        {
            tssl_SystemTimeDisplay.Text = DateTime.Now.ToString();//当日时间显示
        }
        #endregion

        #region 串口的打开及关闭的相关操作方法

        
        /// <summary>
        /// 初始化串口设置参数选项
        /// </summary>
        private void SeralPortComboboxInit()
        {
            //绑定当前计算机的串口名称
            string[] portName = SerialPort.GetPortNames();
            Array .Sort(portName);//排序
            cbb_PortName.DataSource = portName;
            //设置绑定串口波特率
            string []baudRate = new string[] {"614400","19200","38400" ,"115200" , "9600" };
            cbb_BaudRate.DataSource = baudRate;
            //设置绑定串口数据位
            string[] dataBits = new string[] { "8", "7", "6", "5" };
            cbb_DataBits .DataSource = dataBits;  
            //获取枚举停止位常数名称绑定
            cbb_StopBits .DataSource =Enum.GetNames (typeof (StopBits));
            //获取枚举校验位常数名称绑定
            cbb_Parity.DataSource = Enum.GetNames (typeof (Parity)); 
            //单选Hex发送模式
            rb_ReceviedHex .Checked = true;
            //单选Hex接收模式
            rb_SendHex.Checked = true;
            //复选显示发送
            cb_DisplaySend .Checked = true;
            //忽略跨线程操作，不调用错误线程，此操作不赞成使用
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            //触发SerialPort_DataReceived接收事件的字节数
            serialPort.ReceivedBytesThreshold = 1;
            //串口接收数据处理方法
            serialPort.DataReceived += SerialPort_DataReceived;

            serialPort.ReadBufferSize = 614400; // 输入缓冲区大小，单位是字节


        }
      


        /// <summary>
        /// 显示串口信息
        /// </summary>
        private string DisplaySerialPortMessage()
        {
            return   serialPort .PortName + " "
                    + serialPort .BaudRate.ToString() + " "
                    + serialPort .DataBits .ToString () + " "
                    + serialPort .StopBits + " "
                    + serialPort .Parity ;
        }

        /// <summary>
        /// 预选Combobox参数
        /// </summary>
        private void SerialPortSelecte()
        {
            //预选Combobox参数
            if (cbb_PortName.Items.Count > 0)
                cbb_PortName.SelectedIndex = 0;
                cbb_BaudRate.SelectedIndex = 0;
                cbb_DataBits.SelectedIndex = 0;
                cbb_StopBits.SelectedIndex = 1;
                cbb_Parity.SelectedIndex = 0;
                tssl_SerialPortMessage.Text = DisplaySerialPortMessage();
                //串口信息显示为黑色，串口未打开
                if (cbb_PortName.Items.Count > 0)
                    tssl_SerialPortMessage.ForeColor = Color.Black;
                else 
                    tssl_SerialPortMessage.ForeColor = Color.Red;
        }
        /// <summary>
        /// 串口名称下拉部分发生时，实现串口更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbb_PortName_DropDown(object sender, EventArgs e)
        {
            //绑定当前计算机的串口名称
            string[] portName = SerialPort.GetPortNames();
            Array.Sort(portName);//排序
            cbb_PortName.DataSource = portName;
        }
        /// <summary>
        /// 设置串口参数
        /// </summary>
        private bool  SettingSerialPortPara()
        {
            try
            {
                if (cbb_PortName.Text != "")
                {
                    if(serialPort .IsOpen == false)
                    serialPort.PortName = cbb_PortName.Text;
                    serialPort.BaudRate = int.Parse(cbb_BaudRate.Text);
                    serialPort.DataBits = int.Parse(cbb_DataBits.Text);
                    serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbb_StopBits.Text);
                    serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), cbb_Parity.Text);
                    return true;
                }   
                else
                {
                    tssl_SerialPortMessage.ForeColor = Color.Red;
                    return false ;
                } 
                
               
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(ex.Message, "串口参数设置出错！", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    return false ;
                }
                return false;
            }
           
        }
        /// <summary>
        /// 串口打开准备接收或发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_Play_Click(object sender, EventArgs e)
        {
            if(SettingSerialPortPara()==true )
            {
                try
                {
                    if (serialPort.IsOpen == false)
                    {
                        serialPort.Open();
                        tssl_SerialPortMessage.Text = DisplaySerialPortMessage();
                        //串口信息显示为黑色，串口未打开                       
                        tssl_SerialPortMessage.ForeColor = Color.Green ;
                        
                    }                   
                }
                catch (Exception ex)
                {
                    tssl_SerialPortMessage.ForeColor = Color.Red  ;
                    MessageBox.Show(ex.Message, "串口打开出错！", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }
        /// <summary>
        /// 关闭串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_Stop_Click(object sender, EventArgs e)
        {
            if(serialPort .IsOpen )
            {
                GlobalData.Sweep_Flag = 1;
                serialPort.Close();
                tssl_SerialPortMessage.ForeColor = Color.Black ;
            }
        }

        /// <summary>
        /// 窗体关闭时关闭串口，关闭程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                GlobalData.Sweep_Flag = 0;
                delayUs(1000);
                serialPort.Close();
                tssl_SerialPortMessage.ForeColor = Color.Black;
            }
            Application.Exit();  // 关闭应用程序
        }
        #endregion

        #region 串口接收处理

       

        /// <summary>
        /// 串口端口接收数据处理方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {           
            //接收串口字节数组缓存
                        
        }
        /// <summary>
        /// 3、根据委托定义委托方法
        /// </summary>
        private void SerialPortDisplay(byte[]  msg)
        {
            
            
            tssl_RxCounter.Text ="RX:  "+ RxCounter.ToString()+" "; 


        }
        private string ReceviedByte(byte [] bRec)
        {
            DateTime dt = DateTime.Now;//接收信息时的时间
            StringBuilder sBuilder = new StringBuilder();//接收到的串口信息
            sBuilder.Clear();

            if (rb_ReceviedASII.Checked)//字符串接收串口信息
            {
                string rceviedData = Encoding.Default .GetString(bRec);//串口接收到的消息

                
                RxCounter += rceviedData.Length;
                if (cb_AutoLine.Checked)//复选为自动换行
                {
                    sBuilder.Append(rceviedData + Environment.NewLine);
                }

                if (cb_DisplayTime.Checked)//复选为显示时间
                {

                    sBuilder.Insert(0, dt + Environment.NewLine);
                }
                if (!cb_DisplayTime.Checked && !cb_AutoLine.Checked)
                {
                    sBuilder.Append(rceviedData);
                }
                if (cb_DisplaySend.Checked)//复选为发送
                {

                }
            }

            if (rb_ReceviedHex.Checked)//字节数组接收信息
            {
                
                foreach (var item in bRec)
                {
                    sBuilder.Append(item.ToString("x2").ToUpper());
                    sBuilder.Append(" ");
                }
                RxCounter += bRec.Length;
                string rceviedData = sBuilder.ToString();
                sBuilder.Clear();
                if (cb_AutoLine.Checked)//复选为自动换行
                {
                    sBuilder.Append(rceviedData + Environment.NewLine);
                }
                if (cb_DisplayTime.Checked)//复选为显示时间
                {

                    sBuilder.Insert(0, dt + Environment.NewLine);
                }
                if (!cb_DisplayTime.Checked&& !cb_AutoLine.Checked)
                {
                    sBuilder.Append(rceviedData);
                }
                if (cb_DisplaySend.Checked)//复选为发送
                {

                }
            }
            return sBuilder.ToString(); 
        }

        private void stb_Clear_Click(object sender, EventArgs e)
        {
           
            RxCounter= 0;
            TxCounter = 0;  
        }
        #endregion

        #region 串口发送处理

        
        /// <summary>
        /// 串口发送发送区数据
        /// </summary>
        private void SendData()
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(serialPort .IsOpen )
            {
                //如果串口打开，发送发送区相应的数据
                SendData();
            }

            
        }


        #endregion

        #region 正弦信号生成
        private void Creat_Sine_Click(object sender, EventArgs e)
        {
            //定义正弦信号变量名称
            double startFreq, stopFreq,  amplitude, sampleRate, numSteps, samplesPerStep;           
            double shu;
            
            //读取前面板正弦信号给定
            startFreq = float.Parse(Start_Frequency.Text);         // 起始频率(Hz)
            stopFreq = int.Parse(End_Frequency.Text);        // 截止频率(Hz)
            numSteps = int.Parse(Sweep_Step.Text);         // 扫频步数
            samplesPerStep = int.Parse(Step_Number.Text);  // 每步样本数
            amplitude = 1000000;          // 幅值
            sampleRate = int.Parse(Send_Frequency.Text);     // 扫频采样率(Hz)
            double Phase = 0.0;
            M_Input = double.Parse(m_Input.Text);
            M_Output = double.Parse(m_Output.Text);
            O_Magnific = double.Parse(magnific.Text);
            //初始化定义存储正弦信号、发送数组、以及定义输出数组大小
            double[,] Save_Sine_Signal = new double[ (int)numSteps, (int)samplesPerStep ];            
            double[,] Frequency = new double[(int)numSteps, 1];            
            double[,] Receive_Sine = new double[(int)numSteps, (int)samplesPerStep];
            byte[,][] SerReceive = new byte[(int)numSteps, (int)samplesPerStep][];
            byte[,][] SerSend = new byte[(int)numSteps, (int)samplesPerStep][];
            for (int i = 0; i < (int)numSteps; i++)
            {
                for (int j = 0; j < (int)samplesPerStep; j++)
                {
                    SerReceive[i, j] = new byte[7]; // 设定大小，
                    SerSend[i, j] = new byte[7];
                    SerSend[i, j][0] = 0xaa;
                    SerSend[i, j][1] = 0xa6;
                    SerSend[i, j][6] = 0x03;
                }
            }
            // 正弦函数的生成
            for (int i = 0; i <= numSteps - 1; i++)
            {
                Frequency[i, 0] = startFreq * Math.Pow((stopFreq / startFreq), i / (numSteps - 1));

                //Console.WriteLine(Frequency[k, 0]);
                for (int j = 0; j <= (int)samplesPerStep - 1; j++)
                {                   
                    shu = amplitude * Math.Sin((2 * Math.PI * Frequency[i, 0] * (1.0 / sampleRate) * (j + 1)) + Phase);
                    //Save_Sine_Signal[i * (int)samplesPerStep + j, 0] = (Int32)shu;
                    //Console.WriteLine( Save_Sine_Signal[i, k]);
                    //将数据进行处理，
                    if (shu >= 0)
                    {
                        SerSend[i, j][2] = (byte)(((Int32)shu >> 16) & 0xFF);
                        SerSend[i, j][3] = (byte)(((Int32)shu >> 8) & 0xFF);
                        SerSend[i, j][4] = (byte)(((Int32)shu) & 0xFF);
                        SerSend[i, j][5] = (byte)(SerSend[i, j][1] + SerSend[i, j][2] + SerSend[i, j][3] + SerSend[i, j][4]);
                    }
                    else
                    {
                        double fushu = -shu;
                        SerSend[i, j][2] = (byte)((((Int32)(fushu) >> 16) & 0xFF) | 0x40);
                        SerSend[i, j][3] = (byte)(((Int32)(fushu) >> 8) & 0xFF);
                        SerSend[i, j][4] = (byte)(((Int32)(fushu)) & 0xFF);
                        SerSend[i, j][5] = (byte)(SerSend[i, j][1] + SerSend[i, j][2] + SerSend[i, j][3] + SerSend[i, j][4]);
                    }

                }
                Phase = 2 * Math.PI * Frequency[i, 0] * (1.0 / sampleRate) * samplesPerStep + Phase;
            }
            //赋值全局变量
            GlobalData.S_Frequency = Frequency;
            GlobalData.Sendbytes = SerSend;
            GlobalData.Sine_Signal = Save_Sine_Signal;
            GlobalData.Receive_Signal = Receive_Sine;
            GlobalData.Receivebytes = SerReceive;                        
            GlobalData.Num_Step = (int)numSteps;
            GlobalData.Samples_PerStep = (int)samplesPerStep;          
            GlobalData.Sweep_Flag = 1;
            Receive_Data.RunWorkerAsync();            
            Send_Data.RunWorkerAsync();
            Draw.RunWorkerAsync();
            GlobalData.ReadCompletionFlag = 1;
            Delay = (int)(1000000 / sampleRate);
            
        }
        #endregion

        #region 多线程串口发送
        private void Send_Data_DoWork(object sender, DoWorkEventArgs e)
        {            
            while (GlobalData.Sweep_Flag == 1) {
                while ((GlobalData.NumFrequency < (int)GlobalData.Num_Step) && (GlobalData.ReadCompletionFlag == 1))
                {
                    for (Int32 j = 0; j < GlobalData.Samples_PerStep; j++)
                    {
                        Stopwatch sw1 = new Stopwatch();
                        sw1.Start();
                                               
                        serialPort.Write(GlobalData.Sendbytes[GlobalData.NumFrequency, j], 0, GlobalData.Sendbytes[GlobalData.NumFrequency, j].Length);
                        if (j == GlobalData.Samples_PerStep - 1)
                        {
                            GlobalData.ReadCompletionFlag = 0;
                        }
                        sw1.Stop();
                        TimeSpan ts = sw1.Elapsed; 
                        delayUs((int)(Delay - ts.TotalMilliseconds * 1000));
                       
                    }
                   
                }
            }

        }
        #endregion

        #region 多线程接收
        private void Receive_Data_DoWork(object sender, DoWorkEventArgs e)
        {
            int i=0;
            while (GlobalData.Sweep_Flag == 1) {
                if (serialPort.BytesToRead >= 7)
                {
                    if (GlobalData.Sendnum == GlobalData.Samples_PerStep) {
                        GlobalData.Sendnum = GlobalData.Samples_PerStep - 1;
                    }
                    serialPort.Read(GlobalData.Receivebytes[GlobalData.NumFrequency, GlobalData.Sendnum], 0, 7);
                    if (GlobalData.Sendnum % 10 == 0)
                    {
                        i++;
                        var lineSer = plotView1.Model.Series[0] as LineSeries;                       
                        lineSer.Points.Add(new DataPoint(i, Data_Handel(GlobalData.Sendbytes[GlobalData.NumFrequency, GlobalData.Sendnum]) * M_Input));
                        if (i == 200)
                        {
                            lineSer.Points.Clear();

                        }
                        lineSer = plotView1.Model.Series[1] as LineSeries;                        
                        lineSer.Points.Add(new DataPoint(i, Data_Handel(GlobalData.Receivebytes[GlobalData.NumFrequency, GlobalData.Sendnum]) * M_Output * O_Magnific));
                        if (i == 200)
                        {
                            lineSer.Points.Clear();
                            i = 0;
                        }
                        _myPlotModel.InvalidatePlot(true);
                    }


                    GlobalData.Sendnum++;                                       
                                      
                    if (serialPort.BytesToRead == 0 && GlobalData.ReadCompletionFlag == 0) {
                        
                        GlobalData.Sendnum = 0;
                        GlobalData.NumFrequency++;
                        GlobalData.ReadCompletionFlag = 1;
                        PlotBode = 1;

                    }
                    if (GlobalData.NumFrequency == GlobalData.Num_Step) {
                        GlobalData.Sweep_Flag = 0;
                    }
                }                
            }
            
        }
        #endregion

        #region 实时显示图
        private void Draw_DoWork(object sender, DoWorkEventArgs e)
        {
            Task.Factory.StartNew(() =>
            {              
                while (PlotBode != 2)
                {
                    while (PlotBode==1)
                    {                                                
                        var InPut = new System.Numerics.Complex[GlobalData.Samples_PerStep];
                        for (int i = 0; i < GlobalData.Samples_PerStep; i++)
                        {
                            InPut[i] = new System.Numerics.Complex(Data_Handel(GlobalData.Sendbytes[GlobalData.NumFrequency - 1, i]) * M_Input, 0.0f);
                        }
                        Fourier.Forward(InPut, FourierOptions.Matlab);
                        double[] amp_In = InPut.Select(c => c.Magnitude).ToArray();
                        int pos_In = Array.IndexOf(amp_In, amp_In.Max());

                        var OutPut = new System.Numerics.Complex[GlobalData.Samples_PerStep];                        
                        for (int i = 0; i < GlobalData.Samples_PerStep; i++)
                        {
                            OutPut[i] = new System.Numerics.Complex(Data_Handel(GlobalData.Receivebytes[GlobalData.NumFrequency - 1, i]) * M_Output, 0.0f);
                        }
                        Fourier.Forward(OutPut, FourierOptions.Matlab);                 
                        double[] amp_Out = OutPut.Select(c => c.Magnitude).ToArray();                       
                        int pos_Out = Array.IndexOf(amp_Out, amp_Out.Max());
                        var M_lineSer = plotView2.Model.Series[0] as LineSeries;
                        M_lineSer.Points.Add(new DataPoint(GlobalData.S_Frequency[GlobalData.NumFrequency - 1, 0], 20 * Math.Log10((OutPut[pos_Out] / InPut[pos_In]).Magnitude)));
                        _LogPlotMode.InvalidatePlot(true);
                        var P_lineSer = plotView3.Model.Series[0] as LineSeries;
                        if (((OutPut[pos_Out] / InPut[pos_In])).Phase * 180 / Math.PI > 0)
                        {
                            P_lineSer.Points.Add(new DataPoint(GlobalData.S_Frequency[GlobalData.NumFrequency - 1, 0], -((OutPut[pos_Out] / InPut[pos_In])).Phase * 180 / Math.PI));
                        }
                        else {
                            P_lineSer.Points.Add(new DataPoint(GlobalData.S_Frequency[GlobalData.NumFrequency - 1, 0], ((OutPut[pos_Out] / InPut[pos_In])).Phase * 180 / Math.PI));
                        }
                        _PLogPlotMode.InvalidatePlot(true);
                        PlotBode = 0;
                        if (GlobalData.NumFrequency == GlobalData.Samples_PerStep) {
                            PlotBode = 2;
                        }
                    }
                    
                }
            });
        }
        #endregion

        #region 保存
        private void Save_Data_Click(object sender, EventArgs e)
        {

            IWorkbook workbook = new XSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("Sheet1");

            for ( int i=0; i < GlobalData.Num_Step; i++)
            {
                for (Int32 j = 0; j < GlobalData.Samples_PerStep; j++)
                {
                    GlobalData.Sine_Signal[i, j] = Data_Handel(GlobalData.Sendbytes[i, j]);
                    GlobalData.Receive_Signal[i, j] = Data_Handel(GlobalData.Receivebytes[i, j]);
                }
                
            }


            // 写入数据
            for (int i = 0; i < GlobalData.Samples_PerStep; i++)
            {                
                // 创建行
                IRow row = sheet.CreateRow(i);               
                for (int j = 0; j < GlobalData.Num_Step; j++)
                {
                    // 创建单元格，并设置值
                    row.CreateCell(3 * j).SetCellValue(GlobalData.S_Frequency[j, 0].ToString());
                    row.CreateCell(3 * j + 1).SetCellValue(GlobalData.Sine_Signal[j, i].ToString());
                    row.CreateCell(3 * j + 2).SetCellValue(GlobalData.Receive_Signal[j, i].ToString());
                }

            }
            // 保存工作簿到文件
            string filePath = $"{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.xlsx";
            using (FileStream fs = new FileStream($"{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.xlsx", FileMode.Create, FileAccess.Write))
            {
                workbook.Write(fs);
            }
            MessageBox.Show("数据已写入文件。");
            //打开工作簿
            Process.Start(filePath);
        }

        #endregion

        #region 比例放大
        private void Form1_Resize(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Maximized)
            {
                float scaleFactorWidth = (float)this.Width / originalFormWidth;
                float scaleFactorHeight = (float)this.Height / originalFormHeight;

                foreach (Control control in this.Controls)
                {
                    Rectangle originalBounds = originalControlBounds[control];
                    control.Left = (int)(originalBounds.Left * scaleFactorWidth);
                    control.Top = (int)(originalBounds.Top * scaleFactorHeight);
                    control.Width = (int)(originalBounds.Width * scaleFactorWidth);
                    control.Height = (int)(originalBounds.Height * scaleFactorHeight);
                }
            }
        else if (this.WindowState == FormWindowState.Normal)
            {
                // 如果窗体从最大化恢复到正常大小，则恢复控件的初始大小和位置
                foreach (Control control in this.Controls)
                {
                    Rectangle originalBounds = originalControlBounds[control];
                    control.Bounds = originalBounds;
                }
            }
        }
        #endregion


    }
   
}

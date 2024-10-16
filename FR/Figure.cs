using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Annotations;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using static FR.Form1;

namespace FR
{
    public partial class Figure : Form
    {
        private LinearAxis _dateAxis;//X轴
        private LinearAxis _valueAxis;//Y轴
        private PlotModel _myPlotModel;
       
        public Figure()
        {
            InitializeComponent();
            
        }
        #region 设置画板大小
        private void SetPlot()
        {
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
                Position = AxisPosition.Bottom,
                MajorGridlineStyle = OxyPlot.LineStyle.Solid,
                MinorGridlineStyle = OxyPlot.LineStyle.Dot,
                IntervalLength = 80,
                Angle = 0,
                IsZoomEnabled = false,
                IsPanEnabled = false,
                Maximum = 200,
                Minimum = 0,
                // StringFormat = "mm:ss",
                Title = "Time"
            };
            _myPlotModel.Axes.Add(_dateAxis);

            //Y轴
            _valueAxis = new LinearAxis()
            {
                Position = AxisPosition.Left,
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
                StrokeThickness = 2,
                MarkerSize = 1,
                MarkerStroke = OxyColors.DarkGreen,
                MarkerType = MarkerType.Diamond,
                Title = "Temp",
                Smooth = true
            };
            _myPlotModel.Series.Add(series);
            series = new LineSeries()
            {
                Color = OxyColors.Blue,
                StrokeThickness = 2,
                MarkerSize = 1,
                MarkerStroke = OxyColors.BlueViolet,
                MarkerType = MarkerType.Star,
                Title = "Humi",
                Smooth = true
            };
            _myPlotModel.Series.Add(series);


            plotView2.Model = _myPlotModel;
        }
        #endregion
    
        #region 
        
        private double Data_Handel(byte[] Receivebyte) {
            double Rceeive_value = 0.0;
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
                    Receivebyte[2] = (byte)(Receivebyte[2] ^ 0x40);
                    Rceeive_value = -1 * ((Receivebyte[2] << 16) + (Receivebyte[3] << 8) + (Receivebyte[4]));
                }
            }
                return Rceeive_value;
        }
        #endregion 
        #region 定义Figure变量

        int Sendnum_Figure = 0;        
        int NumFrequency_Figure = 0;        
        private static readonly object _lock = new object();
        #endregion

        private void Figure_Load(object sender, EventArgs e)
        {

            SetPlot();
            Draw.RunWorkerAsync();
            
        }

        private void Draw_DoWork(object sender, DoWorkEventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                int i = 0;
                while (true)
                {
                    while (GlobalData.Sweep_Flag == 1  && GlobalData.Sendnum > 1) 
                    {
                        i++;
                        double fuzhi = 0;                     
                        NumFrequency_Figure = GlobalData.NumFrequency;
                        Sendnum_Figure = GlobalData.Sendnum - 1;                                                                      
                        var lineSer = plotView2.Model.Series[0] as LineSeries;
                        //fuzhi = Data_Handel(GlobalData.Receivebytes[NumFrequency_Figure, Sendnum_Figure]) * 0.0000001;
                        //lineSer.Points.Add(new DataPoint(i, fuzhi));
                        //if (lineSer.Points.Count > 200)
                        //{
                        //    lineSer.Points.RemoveAt(0);
                        //}
                        //if (i % 200 == 0)
                        //{
                        //    lineSer.Points.Clear();
                        //}
                        lineSer = plotView2.Model.Series[1] as LineSeries;
                        fuzhi = Data_Handel(GlobalData.Sendbytes[0, i])*0.0000004;
                        GlobalData.Sine_Signal[0, i] = Sendnum_Figure;
                        lineSer.Points.Add(new DataPoint(i, fuzhi));
                        if (lineSer.Points.Count > 200)
                        {
                            lineSer.Points.RemoveAt(0);
                        }
                        if (i % 200 == 0)
                        {
                            lineSer.Points.Clear();
                            i = 0;
                        }
                        _myPlotModel.InvalidatePlot(true);
                        Thread.Sleep(10);
                    }
                   
                }
            });
                   
        }

        private void Count_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}

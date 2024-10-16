using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FR
{
   
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]


        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // 启动第一个窗口
            Form1 form1 = new Form1();
            form1.Show();
            // 启动第二个窗口
            //Figure form2 = new Figure();
            //form2.Show();
            // 保持应用程序运行
            Application.Run();
            
        }
    }
}

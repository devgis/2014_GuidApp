using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using guide_form;

namespace guide
{
    public class guide
    {
        public static int max_ver_num = 27;
        public static int MAX = 65535;
    }

    public class mgraph
    {
        public int[] no = new int[guide.max_ver_num];
        public String[] name = new String[guide.max_ver_num];
        public String[] info = new String[guide.max_ver_num];
        public int[,] arcs = new int[guide.max_ver_num, guide.max_ver_num];
        public int vernum,arcnum;
    }

    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new guide_form.Form1());
        }
    }
}

using System;
using System.IO;
using System.Windows.Forms;

namespace SqlExcel
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Sunisoft.IrisSkin.SkinEngine skinEngine = new Sunisoft.IrisSkin.SkinEngine();
            string skinPath = Application.StartupPath + Path.DirectorySeparatorChar + "skin" + Path.DirectorySeparatorChar + "skin.ssk";
            skinEngine.SkinFile = skinPath;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

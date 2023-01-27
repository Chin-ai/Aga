using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ardin
{
    static class Data
    {
        public static string Glob_connection_string = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\ardin\ardin\AvtoBase.mdf;Integrated Security = True; Connect Timeout = 30";
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary> E:\ardin\ardin\AvtoBase.mdf
        [STAThread]
        static void Main() 
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); /// lkwhef,mbm
            Application.Run(new Menu());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    static class Program
    {
        public static SQLHelper SqlHelper = new SQLHelper(); // Bir defa nesne ürettik sürekli nesne üretmeye gerek kalmadı. 

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Ayar.GetDefaultLanguage();
            Application.Run(new Form1());
        }
    }
}

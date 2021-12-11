using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace epuletek
{
    static class Program
    {
        public static Form1 form1 = null; 
        public static Form_Csaladihaz form_csalad = null; 
        public static Form_Tombhaz form_tomb = null; 
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            form1 = new Form1();
            form_csalad = new Form_Csaladihaz();
            form_tomb = new Form_Tombhaz();

            Application.Run(form1);
        }
    }
}

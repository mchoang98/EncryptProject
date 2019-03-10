using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirusWinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // if (args.Length <= 0)

            //ScanFileAndCrypt scf = new ScanFileAndCrypt();
            //scf.DirectorySearch(@"C:\Users\Admin\Desktop\Filetest");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            //    } else
            //    {
            //        MessageBox.Show(String.Format("Your inputed key is: {0}", args[0]));
            //        Console.WriteLine(String.Format("Your inputed key is: {0}", args[0]));
            //    }
            //}
        }
    }
}
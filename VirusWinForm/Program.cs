using System;
using System.Collections.Generic;

using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using static VirusWinForm.Wallpaper;

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

            // ScanFileAndCrypt scf = new ScanFileAndCrypt();

            //scf.DirectorySearch(@"C:\Users\DELL\Downloads\hack");
           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form3());
            //    } else
            //    {
            //        MessageBox.Show(String.Format("Your inputed key is: {0}", args[0]));
            //        Console.WriteLine(String.Format("Your inputed key is: {0}", args[0]));
            //    }
            //}
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp = System.Windows.Forms.Application;

namespace AE.PresentationUI
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WinFormsApp.EnableVisualStyles();
            WinFormsApp.SetCompatibleTextRenderingDefault(false);
            WinFormsApp.Run(new Form1());
        }
    }
}

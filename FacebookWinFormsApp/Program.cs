// $G$ THE-001 (-5) your grade on diagrams document - 69. please see comments inside the document. 40% of your grade).

using System;
using System.Windows.Forms;
using FacebookWrapper;

namespace FacebookApp
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Clipboard.SetText("design.patterns21cc");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
            //Application.Run(new FormDemo());
        }
    }
}

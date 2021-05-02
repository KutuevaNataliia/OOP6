using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP6
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        delegate void DS(object source, EventArgs å);

        [STAThread]

        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());

            
            //void DS(object source, EventArgs å) { };
        }
    }
}

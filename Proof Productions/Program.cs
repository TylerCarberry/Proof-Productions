using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proof_Productions
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Run different Forms
            Application.Run(new MainMenuForm());

            /**TODO - Program doesn't terminate properly when closing 
               from a Form other than MainMenuForm
               Possible solutions/suggestions are below */
            //Application.Exit();
            //new MainMenuForm().Close();
        }
    }
}

using Proof_Productions.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proof_Productions.Model;

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

            /*testing for database
             * TODO - delete later
            Cue cue = new Cue();
            DataAccess da = new DataAccess();
            da.connect();
            //Console.WriteLine(da.getCueID());
            Console.WriteLine("Testing");
            da.disconnect();
            */

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

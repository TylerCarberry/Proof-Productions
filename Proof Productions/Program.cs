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

            
            BaseForm form = new MainMenuForm();
            BaseForm formToShowNext = null;
            
            int leftPosition = 0;
            int topPosition = 0;

            while (form != null)
            {
                using (form)
                {

                    form.StartPosition = FormStartPosition.Manual;
                    form.Top = topPosition;
                    form.Left = leftPosition;
                    Application.Run(form);

                    formToShowNext = form.FormToOpenNext;

                    // Prevents the GUI from jumping around as you switch forms
                    leftPosition = form.Left;
                    topPosition = form.Top;
                }

                form = formToShowNext;
            }
            
        }
    }
}

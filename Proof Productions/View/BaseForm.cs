using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proof_Productions.View
{
    public class BaseForm : Form
    {

        public BaseForm FormToOpenNext;

        protected void SwitchToForm(BaseForm form)
        {
            FormToOpenNext = form;
            this.Close();
        }

    }
}

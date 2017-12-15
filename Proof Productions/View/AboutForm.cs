using System;
using System.Windows.Forms;

namespace Proof_Productions.View
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void UrlLabel_Click(object sender, EventArgs e)
        {
            OpenUrl("http://www.proofproductionsinc.com");
        }

        private void AuthorLabel_Click(object sender, EventArgs e)
        {
            OpenUrl("https://www.youtube.com/results?search_query=funny+cat+videos");
        }

        private void OpenUrl(String url)
        {
            System.Diagnostics.Process.Start(url);
        }
    }
}

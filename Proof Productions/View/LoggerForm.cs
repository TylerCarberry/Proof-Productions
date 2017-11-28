using Proof_Productions.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proof_Productions.View
{
    public partial class LoggerForm : Form
    {
        public LoggerForm()
        {
            InitializeComponent();

            ReadFromFile();
        }

        private void ReadFromFile()
        {
            String[] logArray;
            try
            {
                logArray = File.ReadAllLines(Logger.getLogPath());
            }
            catch (FileNotFoundException e)
            {
                return;
            }

            foreach (String item in logArray)
            {
                String date = item.Substring(0, item.IndexOf("-"));
                String time = item.Substring(item.IndexOf("-") + 2, item.IndexOf("|") - item.IndexOf("-") - 2);
                String message = item.Substring(item.IndexOf("|") + 2);

               logGridView.Rows.Add(date, time, message);
            }
        }

        private void displayErrorButton_Click(object sender, EventArgs e)
        {

        }

        private void displayLogButton_Click(object sender, EventArgs e)
        {

        }

        private void logLocationButton_Click(object sender, EventArgs e)
        {
            String filePath = Logger.getLogPath();
            String argument = "/select, \"" + filePath + "\"";

            System.Diagnostics.Process.Start("explorer.exe", argument);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void logGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void switchToForm(Form form)
        {
            form.Show();
            form.Left = this.Left;
            form.Top = this.Top;

            this.Hide();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchToForm(new MainMenuForm());
        }

        private void setupMotorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchToForm(new SetupMotorForm());
        }

        private void manualControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchToForm(new ManualControlForm());
        }

        private void setupCuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switchToForm(new SetupCueForm());
        }

        private void loggerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO - Do we even need this? Already at Logger page
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().Show();
        }
    }
}

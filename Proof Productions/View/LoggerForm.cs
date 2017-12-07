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

       
    }
}

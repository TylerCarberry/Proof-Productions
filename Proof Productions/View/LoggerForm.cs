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
            catch (DirectoryNotFoundException e)
            {
                return;
            }

            logGridView.Rows.Clear();
            foreach (String item in logArray)
            {
                String date = item.Substring(0, item.IndexOf("-"));
                String time = item.Substring(item.IndexOf("-") + 2, item.IndexOf("|") - item.IndexOf("-") - 2);
                String message = item.Substring(item.IndexOf("|") + 2);

               logGridView.Rows.Insert(0, date, time, message);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ReadFromFile();
        }

        private void logLocationButton_Click(object sender, EventArgs e)
        {
            String filePath = Logger.getLogFolder();
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

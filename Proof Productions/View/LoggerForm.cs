using Proof_Productions.Controller;
using System;
using System.IO;
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

        /// <summary>
        /// Read the  logs from a file and populate the GUI
        /// </summary>
        private void ReadFromFile()
        {
            String[] logArray;
            try
            {
                logArray = File.ReadAllLines(Logger.getLogPath());
            }
            catch (IOException e)
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

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ReadFromFile();
        }

        /// <summary>
        /// Open the log file in the file explorer
        /// </summary>
        private void LogLocationButton_Click(object sender, EventArgs e)
        {
            String filePath = Logger.getLogFolder();
            String argument = "/select, \"" + filePath + "\"";

            System.Diagnostics.Process.Start("explorer.exe", argument);
        }

    }
}

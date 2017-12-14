﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Controller
{
    class Logger
    {

        public static String getLogFolder()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\proofProductionLogs\\";
        }
        
        public static String getLogPath()
        {
            return getLogFolder() + "log-" + DateTime.Now.ToString("MMddyyyy") + ".txt";
        }

        public static void makeLogFolderIfDoesntExist()
        {
            System.IO.Directory.CreateDirectory(getLogFolder());
        }

        public static void LogInfo(String message)
        {
            makeLogFolderIfDoesntExist();
            System.IO.File.AppendAllText(getLogPath(), CurrentTime() + " | ");
            System.IO.File.AppendAllText(getLogPath(), FormatMessage(message));
            System.IO.File.AppendAllText(getLogPath(), System.Environment.NewLine);
        }

        public static void LogError(String message)
        {
            makeLogFolderIfDoesntExist();
            System.IO.File.AppendAllText(getLogPath(), CurrentTime() + " | ERROR ");
            System.IO.File.AppendAllText(getLogPath(), FormatMessage(message));
            System.IO.File.AppendAllText(getLogPath(), System.Environment.NewLine);
        }

        private static String CurrentTime()
        {
            return DateTime.Now.ToString("MM/dd/yyyy - h:mm:ss tt");
        }

        private static String FormatMessage(String message)
        {
            return message.Replace(System.Environment.NewLine, " ");
        }

    }
}

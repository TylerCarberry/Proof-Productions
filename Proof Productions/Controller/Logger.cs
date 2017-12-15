using System;

namespace Proof_Productions.Controller
{
    class Logger
    {

        // The log files get saved to my documents
        public static String GetLogFolder()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\proofProductionLogs\\";
        }
        
        // The files are named log-date
        // Ex: log-12152017
        public static String GetLogPath()
        {
            return GetLogFolder() + "log-" + DateTime.Now.ToString("MMddyyyy") + ".txt";
        }

        public static void MakeLogFolderIfDoesntExist()
        {
            System.IO.Directory.CreateDirectory(GetLogFolder());
        }

        public static void LogInfo(String message)
        {
            MakeLogFolderIfDoesntExist();
            System.IO.File.AppendAllText(GetLogPath(), CurrentTime() + " | ");
            System.IO.File.AppendAllText(GetLogPath(), FormatMessage(message));
            System.IO.File.AppendAllText(GetLogPath(), System.Environment.NewLine);
        }

        public static void LogError(String message)
        {
            MakeLogFolderIfDoesntExist();
            System.IO.File.AppendAllText(GetLogPath(), CurrentTime() + " | ERROR ");
            System.IO.File.AppendAllText(GetLogPath(), FormatMessage(message));
            System.IO.File.AppendAllText(GetLogPath(), System.Environment.NewLine);
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

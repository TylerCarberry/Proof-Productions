using System;

namespace Proof_Productions.Controller
{
    class Logger
    {
        ///<summary>
        ///This finds the log folder in "MyDocuments" to store the Log file in.
        ///</summary>
        public static String GetLogFolder()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\proofProductionLogs\\";
        }
      
        /// <summary>
        /// This sets the name of the Log file to "log-MMddyyyy.txt", where MMddyyyy
        /// is the date at which the Log was created
        /// </summary>
        public static String GetLogPath()
        {
            return GetLogFolder() + "log-" + DateTime.Now.ToString("MMddyyyy") + ".txt";
        }

        /// <summary>
        /// If no Log folder exists in "MyDocuments", then a new folder is created.
        /// </summary>
        public static void MakeLogFolderIfDoesntExist()
        {
            System.IO.Directory.CreateDirectory(GetLogFolder());
        }

        /// <summary>
        /// This applies the current time to the Log file,
        /// followed by the Log's message itself when sending.
        /// It then automatically goes to the next line for the next Log.
        /// </summary>
        public static void LogInfo(String message)
        {
            MakeLogFolderIfDoesntExist();
            System.IO.File.AppendAllText(GetLogPath(), CurrentTime() + " | ");
            System.IO.File.AppendAllText(GetLogPath(), FormatMessage(message));
            System.IO.File.AppendAllText(GetLogPath(), System.Environment.NewLine);
        }

        /// <summary>
        /// When an error occurs, the time is printed into the log followed by a declaration of error.
        /// Then the message of why there is an error is printed.
        /// Followed by a new line for the next Log.
        /// </summary>
        public static void LogError(String message)
        {
            MakeLogFolderIfDoesntExist();
            System.IO.File.AppendAllText(GetLogPath(), CurrentTime() + " | ERROR ");
            System.IO.File.AppendAllText(GetLogPath(), FormatMessage(message));
            System.IO.File.AppendAllText(GetLogPath(), System.Environment.NewLine);
        }

        /// <summary>
        /// This will send the current date and time when called, used in Log entries.
        /// </summary>
        private static String CurrentTime()
        {
            return DateTime.Now.ToString("MM/dd/yyyy - h:mm:ss tt");
        }

        /// <summary>
        /// This turns Log messages into a single line instead of moving to a new line.
        /// </summary>
        private static String FormatMessage(String message)
        {
            return message.Replace(System.Environment.NewLine, " ");
        }

    }
}

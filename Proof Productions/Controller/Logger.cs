using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Controller
{
    class Logger
    {
        public const String FilePath = @"C:\Users\shop\Desktop\log.txt";

        public static void LogInfo(String message)
        {
            System.IO.File.AppendAllText(FilePath, CurrentTime() + " | ");
            System.IO.File.AppendAllText(FilePath, FormatMessage(message));
            System.IO.File.AppendAllText(FilePath, System.Environment.NewLine);
        }

        public static void LogError(String message)
        {
            System.IO.File.AppendAllText(FilePath, CurrentTime() + " | ERROR ");
            System.IO.File.AppendAllText(FilePath, FormatMessage(message));
            System.IO.File.AppendAllText(FilePath, System.Environment.NewLine);
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

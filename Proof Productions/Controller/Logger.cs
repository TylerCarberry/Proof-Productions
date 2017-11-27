using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proof_Productions.Controller
{
    class Logger
    {
        public const String FilePath = @"C:\Users\Public\ProofProductions\log.txt";

        public static void LogInfo(String message)
        {
            System.IO.File.WriteAllText(FilePath, CurrentTime() + ": ");
            System.IO.File.WriteAllText(FilePath, message);
            System.IO.File.WriteAllText(FilePath, "\n");
        }

        public static void LogError(String message)
        {
            System.IO.File.WriteAllText(FilePath, CurrentTime() + ": *ERROR* ");
            System.IO.File.WriteAllText(FilePath, message);
            System.IO.File.WriteAllText(FilePath, "\n");

        }

        private static String CurrentTime()
        {
            return DateTime.Now.ToString("MM/dd/yyyy h:mm:ss tt");
        }

    }
}

using System;

namespace accountStatement
{
    internal static class Logger
    {
        public static void LogFile(string[] file)
        {
            if (!Program.DisplayDebugInfo) return;
            foreach (string s in file)
            {
                Console.WriteLine(s);
            }
        }
    }
}
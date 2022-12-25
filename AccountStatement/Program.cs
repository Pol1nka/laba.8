using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace accountStatement
{
    internal static class Program
    {
        /*
         * confiigg
         */
        public static readonly bool IsNeedToSort = false;
        public static readonly bool DisplayDebugInfo = false;
        public static readonly string Filename = "success.txt";

        public static Dictionary<string, int> _balanceHistory;
        public static int _totalBalance;

        public static void Main()
        {
            while (true)
            {
                Console.Clear();

                string[] result = Helper.GetFileContent(Filename);
                Logger.LogFile(result);
                HistoryHandler.Handle(result);
                Thread.Sleep(3000);
            }
        }
    }
}
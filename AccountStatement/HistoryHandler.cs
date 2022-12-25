using System;
using System.Collections.Generic;

namespace accountStatement
{
    internal static class HistoryHandler
    {
        public static void Handle(string[] history)
        {
            Program._balanceHistory = new Dictionary<string, int>();
            int balance = int.Parse(history[0]);
            for (int i = 1; i < history.Length; i++)
            {
                string[] rowInfo = Helper.GetRowInfo(history[i]);

                if (rowInfo.Length == 3)
                {
                    switch (rowInfo[2])
                    {
                        case "in":
                            balance += int.Parse(rowInfo[1]);
                            break;

                        case "out":
                            balance -= int.Parse(rowInfo[1]);
                            break;
                    }
                }
                else
                {
                    string[] previousRowInfo = Helper.GetRowInfo(history[i - 1]);
                    if (previousRowInfo[2] == "in")
                    {
                        balance -= int.Parse(previousRowInfo[1]);
                    }
                    else
                    {
                        balance += int.Parse(previousRowInfo[1]);
                    }
                }

                Program._balanceHistory[rowInfo[0].Trim()] = balance;
            }

            if (balance < 0)
            {
                Console.WriteLine("Расход превысил остаток по карте");
                return;
            }

            Program._totalBalance = balance;
            UserInputHandler.Handle();
        }
    }
}
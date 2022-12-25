using System;
using System.Text.RegularExpressions;

namespace accountStatement
{
    internal static class UserInputHandler
    {
        public static void Handle()
        {
            while (true)
            {
                Console.Write("Введите дату и время в формате гггг-мм-дд чч:мм или нажмите [Enter], чтобы отобразить итоговый баланс: ");
                string userInput = Console.ReadLine();

                if (userInput is null or "")
                {
                    Console.WriteLine($"Остаток в конце: {Program._totalBalance}");
                    return;
                }

                userInput = userInput.Trim();
                bool isDateValid = Regex.IsMatch(userInput, @"^\d{4}-\d{2}-\d{2} \d{2}:\d{2}$");
                if (!isDateValid)
                {
                    Console.WriteLine("Неверный формат даты!");
                    continue;
                }

                int balance = Program._balanceHistory[userInput.Replace(" ", "")];
                Console.WriteLine($"Баланс на момент {userInput} равен {balance}");
                break;
            }
        }
    }
}
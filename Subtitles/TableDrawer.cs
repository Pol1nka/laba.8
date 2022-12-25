using System;
using System.Threading;

namespace Subtitles
{
    public static class TableDrawer
    {
        public static int Width = 50;
        public static int Height = 20;
        private static int timeout = 1;

        public static void DrawTable()
        {
            // Отрисовка верхней границы таблицы
            for (int i = 0; i < Width + 2; i++)
            {
                Console.Write("─");
                Thread.Sleep(timeout);
            }
            Console.WriteLine();
            

            // Отрисовка вертикальных границ таблицы
            for (int i = 0; i < Height; i++)
            {
                Console.Write("│");
                for (int j = 0; j < Width; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("│");
                Thread.Sleep(timeout);
            }
            
            // Отрисовка верхней границы таблицы
            for (int i = 0; i < Width + 2; i++)
            {
                Console.Write("─");
                Thread.Sleep(timeout);
            }
            
        }
    }
}
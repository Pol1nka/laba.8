using System;
using System.Threading;

namespace Subtitles
{
    public class SubtitleOutputer
    {
        private static int runTime;
        private Subtitle[] subtitles;

        public SubtitleOutputer(Subtitle[] subtitles)
        {
            this.subtitles = subtitles;
        }

        public void BeignWork()
        {
            TimerCallback timerCallback = new TimerCallback(Test);
            Timer timer = new Timer(timerCallback, subtitles, 0, 1000);
        }

        private static void Test(object obj)
        {
            Subtitle[] input = (Subtitle[])obj;
            foreach (Subtitle subtit in input)
            {
                if (subtit.TimeStart == runTime)
                    WriteSubtitle(subtit);
                else if (subtit.TimeEnd == runTime)
                    RemoveSubtitle(subtit);
            }

            runTime++;
            Console.SetCursorPosition(0, TableDrawer.Height + 3);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(runTime-1);
        }
        

        private static void WriteSubtitle(Subtitle subtit)
        {
            SetPosition(subtit);
                
            if (subtit.TextColor.Trim().Equals("Red")) Console.ForegroundColor = ConsoleColor.Red;
            if (subtit.TextColor.Trim() == "Blue") Console.ForegroundColor = ConsoleColor.Blue;
            if (subtit.TextColor.Trim() == "Green") Console.ForegroundColor = ConsoleColor.Green;
            if (subtit.TextColor.Trim() == "White") Console.ForegroundColor = ConsoleColor.White;
                
            Console.Write(subtit.Phrase);
        }

        private static void RemoveSubtitle(Subtitle subtit)
        {
            SetPosition(subtit);
            for (int i = 0; i < subtit.Phrase.Length; i++)
                Console.Write(" ");
        }

        private static void SetPosition(Subtitle subtit)
        {
            switch (subtit.Position)
            {
                case "Top":
                    Console.SetCursorPosition((TableDrawer.Width - subtit.Phrase.Length) / 2, 1);
                    break;
                case "Right":
                    Console.SetCursorPosition(TableDrawer.Width - subtit.Phrase.Length,
                        (TableDrawer.Height - 1) / 2 + 1);
                    break;
                case "Bottom":
                    Console.SetCursorPosition((TableDrawer.Width - subtit.Phrase.Length) / 2, TableDrawer.Height);
                    break;
                case "Left":
                    Console.SetCursorPosition(1, (TableDrawer.Height - 1) / 2 + 1);
                    break;
                default:
                    break;
            }

        }
    }
}
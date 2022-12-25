using System;
using System.Collections.Generic;
// using System.Diagnostics.Tracing;
using System.IO;
using System.Linq;
// using System.Runtime.CompilerServices;
using System.Threading;

namespace Subtitles
{
    class Program
    {
        public static void Main(string[] args)
        {
            TableDrawer.DrawTable();
            
            string[] initialStrings = File.ReadAllLines("subs.txt");
            Subtitle[] subtitles = new Subtitle[initialStrings.Length];
            for (int i = 0; i < initialStrings.Length; i++)
            {
                subtitles[i] = SubtitleCreator.CreateSubtitle(initialStrings[i]);
            }
            
            SubtitleOutputer shower = new SubtitleOutputer(subtitles);
            shower.BeignWork();

            Console.ReadLine();
        }
    }
}
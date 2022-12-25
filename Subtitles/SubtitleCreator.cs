using System.Collections.Generic;
using System.Linq;

namespace Subtitles
{
    class SubtitleCreator
    {
        public static Subtitle CreateSubtitle(string initialString)
        {
            int startTime = GetTimeStart(initialString);
            int endTime = GetTimeEnd(initialString);
            string position = GetPosition(initialString);
            string phrase = GetPhrase(initialString);
            string textColor = GetColor(initialString);

            return new Subtitle(startTime, endTime, position, phrase, textColor);
        }

        public static int GetTimeStart(string initialString)
        {
            int startTime = int.Parse(initialString.Split('-')[0].Split(' ')[0].Split(':')[1]);
            return startTime;
        }

        public static int GetTimeEnd(string initialString)
        {
            int endTime = int.Parse(initialString.Split('-')[1].Split(' ')[1].Split(':')[1]);
            return endTime;
        }

        public static string GetPosition(string initialString)
        {
            string position = "";
            if (initialString.Contains("["))
                position = initialString.Split('[')[1].Split(',')[0];
            else
            {
                position = "Bottom";
            }

            return position;
        }

        public static string GetColor(string initialString)
        {
            string colors = null;
            if (initialString.Contains("]"))
                colors = initialString.Split(']')[0].Split(',')[1];

            if (colors != null && (colors.Equals("") || colors.Length == 0) || colors == null) colors = "White";


            return colors;
        }

        public static string GetPhrase(string initialString)
        {
            string text = "";
            if (initialString.Contains("[") || initialString.Contains("]"))
                text = initialString.Split(']')[1];
            else
            {
                string[] phrases = initialString.Split(' ');

                List<string> words = phrases.ToList();
                words.RemoveAt(0);
                words.RemoveAt(0);
                words.RemoveAt(0);

                text = string.Join(" ", words);
            }

            return text;
        }
    }
}
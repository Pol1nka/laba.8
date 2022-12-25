namespace Subtitles
{
    public class Subtitle
    {
        public int TimeStart { get; }
        public int TimeEnd { get; }
        public string Position { get; }
        public string Phrase { get; }
        public string TextColor { get; }

        public Subtitle(int timeStart, int timeEnd, string position, string phrase, string textColor)
        {
            TimeStart = timeStart;
            TimeEnd = timeEnd;
            Position = position;
            Phrase = phrase;
            TextColor = textColor;
        }
    }
}
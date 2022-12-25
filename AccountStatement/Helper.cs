using System.IO;
using System.Linq;

namespace accountStatement
{
    internal static class Helper
    {
        public  static string[] GetRowInfo(string row)
        {
            return row.Replace(" ", "").Split('|');
        }

        public static string[] GetFileContent(string filename)
        {
            return Program.IsNeedToSort ? File
                .ReadAllText(filename)
                .Split('\n')
                .Select(x => x.Split('|'))
                .OrderBy(x => x[0])
                .Select(x => string.Join("|", x)).ToArray() : File.ReadAllText(filename).Split('\n');
        }
    }
}
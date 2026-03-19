using System.Security.Cryptography.X509Certificates;

namespace ExtensionMethods
{
    public static class ExtensionStringParser
    {
        public static string RemoveSpecificCharapters(this string line)
        {
            return line.Replace("#", " ").Replace("?", " ").Replace("*", " ").Replace("!"," ").Replace("@"," ").Replace("#"," ");
        }

        public static string WordUpper(this string line)
        {
            string[] words = line.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(words[i]))
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
                }
            }

            string result = string.Join(' ', words);

            return result;
        }
    }
}

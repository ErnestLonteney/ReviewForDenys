using System;
using System.Collections;
using System.Text;

namespace Yield
{
    static class Words
    {
        public static IEnumerable GenerateWords(string input)
        {
            if (input == null)
            {
                yield break; // stop the generator
            }

            for (int i = 0; i < input.Length; i++)
            {
                yield return $"{i} - {input}";
            }
        }
    }
}

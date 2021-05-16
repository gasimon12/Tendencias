using System;

namespace Anagrams
{
    public class AnagramsClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public bool Check(string word1, string word2)
        {
            if (word1 == null || word2 == null)
            {
                throw new ArgumentNullException();
            }
            if (word1.Length != word2.Length)
            {
                return false;
            }
            else
            {
                word1 = Sanitize(word1);
                word2 = Sanitize(word2);
                if (word1 == word2)
                {
                    return true;
                }
                else
                {
                    return true;
                }
            }
        }
        public string Sanitize(string input)
        {
            char[] temp = input.ToLowerInvariant().ToCharArray();
            Array.Sort(temp);
            return new string(temp);
        }
    }
}

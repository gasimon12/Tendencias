using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Anagramas
{
    public class Anagrams
    {
        private Dictionary<string, LinkedList<string>> dictionary = new Dictionary<string, LinkedList<string>>();
        static void Main(string[] args)
        {
            var timer = Stopwatch.StartNew();
            Anagrams anagrams = new();
            StreamReader reader = new StreamReader(args[0]);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                anagrams.Check(line);
            }
            var (setCount, wordCount) = anagrams.Print();
            timer.Stop();
            Console.WriteLine($"Duracion: {timer.Elapsed.TotalMilliseconds}ms");
            Console.WriteLine($"Conjuntos de anagramas: {setCount} \nAnagramas: {wordCount}");
        }
        public string Sanitize(string raw)
        {
            char[] temp = raw.ToCharArray();
            Array.Sort(temp);
            return new string(temp);
        }
        public (int, int) Print()
        {
            var (setCount, wordCount) = (0, 0);
            int count;
            StreamWriter writer = new(@".\output.txt");
            foreach (var pair in dictionary)
            {
                count = pair.Value.Count;
                if (count > 1)
                {
                    setCount++;
                    wordCount += count;
                    foreach (string anagram in pair.Value)
                    {
                        writer.Write($"{anagram} ");
                    }
                    writer.WriteLine("");
                }
            }
            writer.Close();
            return (setCount, wordCount);
        }
        public bool Check(string raw)
        {
            string key = Sanitize(raw);
            bool match = dictionary.ContainsKey(key);
            if (match == true)
            {
                dictionary.TryGetValue(key, out var list);
                list.AddLast(raw);
            }
            else
            {
                dictionary.Add(key, new LinkedList<string>());
                dictionary.TryGetValue(key, out var list);
                list.AddLast(raw);
            }
            return match;
        }
    }
}

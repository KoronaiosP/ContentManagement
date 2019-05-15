using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ContentManagement
{
    public class FormattedText : IContent
    {
        public string SomeWords { get; set; }

        //Constructor
        public FormattedText(string someWords) 
        {
            SomeWords = someWords;
        }

        //Counts words contained to a string
        public int CountWords()
        {
            string[] words = SomeWords.Split(" ");
            int numwords = words.Length;
            return numwords;
        }

        //Locates the Lengthiest word contained to an array of strings
        public string LengthiestWord()
        {
            string[] words = SomeWords.Split(" ");
            string longestWord = " ";
            for (int i = 0; i< words.Length; i++)
            {
                if (words[i].Length > longestWord.Length)
                {
                    longestWord = words[i];
                }
            }
            return longestWord;
        }

        //Loads data from a text file and saves them within a list
        public bool LoadText(string fileName)
        {
            var list = new List<string>();
            var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read); 
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null) 
                {
                    list.Add(line);
                }
            }
            foreach (String s in list)
            {
                Console.WriteLine("----------------");
                Console.WriteLine(s);
            }
            return true;
        }

        //Creates a text file to a specific filePath and writes string to it.
        public bool SaveText(string filePath)
        {
            string[] tempSomeWords = new string[1];
            tempSomeWords[0] = SomeWords;

            File.WriteAllLines(filePath, tempSomeWords); 
            return true;
        }
    }
}

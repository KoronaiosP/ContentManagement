using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ContentManagement
{
    public class SimpleText : IContent 
    {
        public List<string> Sentences { get; set; } = new List<string>();

        //Constructor
        public SimpleText(List<string> sentences) 
        {
            Sentences = sentences;
        }
        //Counts words to a List of strings
        public int CountWords()
        {
            int numwords = 0;
            foreach (string sent in Sentences)
            {
                string[] words = sent.Split(" "); //Θεωρώ ότι το διαχωριστικό είναι το κενό, μετράω τις λέξεις και τις καταχωρώ στον πίνακα words
                numwords += words.Length;         //Βάζω το πλήθος των στοιχείων του πίνακα στην μεταβλητή numwords
            }
            return numwords;
        }

        //Locates the Lengthiest word to a List of strings
        public string LengthiestWord()
        {
            string biggest = "";                         //Ορίζω μια μεταβλητή biggest για το μήκος της λέξης
            foreach (string sent in Sentences)          // Για κάθε λέξη του πίνακα words, ελέγχω το μήκος της και εάν είναι μεγαλύτερο από το μήκος του biggest (που είναι null) και εάν είναι, το καταχωρώ. 
            {
                string[] words = sent.Split(" ");
                foreach (string w in words)
                {

                    if (biggest.Length < w.Length)
                    {
                        biggest = w;
                    }
                }

            }
            return biggest;
        }
        //Loads data from a text file and saves them within a list
        public bool LoadText(string fileName) 
        {
            try 
            {
                var list = new List<string>();
                var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read); //Το αντικείμενο fileStream είναι τύπου FileStream και εντοπίζει ένα αρχείο κειμένου και το ανοίγει για ανάγνωση.
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null) //
                    {
                        list.Add(line);
                    }
                }
                foreach (String s in list)
                {
                    Console.WriteLine("----------------");
                    Console.WriteLine(s);
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        //Creates a text file to a specific filePath and writes a list of strings to it.
        public bool SaveText(string filePath)
        {
            File.WriteAllLines(filePath, Sentences); 
            return true;
        }
    }
}

using System;
using System.Collections.Generic;

namespace ContentManagement
{

   class Programm
    {
        static void Main(string[] args)
        {
            //Data insert to a list
            var Phrases = new List<string>(); 
            Phrases.Add("Mahesh Chand");
            Phrases.Add("Praveen Kumar");
            Phrases.Add("Raj Kumar");
            Phrases.Add("Nipun Tomar");

            var Document = new SimpleText(Phrases);
            Document.SaveText(@"C:\Users\Name\WriteLines.txt");
            //--------------------------------------------------------------------------------------------------

            var Phrase = new FormattedText("My Name is Alexander");
            Phrase.SaveText(@"C:\Users\Name\myname.txt");
        }
    }

}
    


using System;
using System.Collections.Generic;
using System.Text;

namespace ContentManagement
{
    interface IContent
    {
        int CountWords(); //Μέθοδος που θα μετράει τις λέξεις
        string LengthiestWord(); //Μέθοδος που θα επιστρέφει την μεγαλύτερη λέξη
        bool LoadText(string fileName); //Μέθοδος που θα φορτώνει ένα αρχείο txt και θα το εμφανίζει στην κονσόλα.
        bool SaveText(string path);//Μέθοδος που θα αποθηκεύει ένα κείμενο σε ένα αρχείο txt

    }
}

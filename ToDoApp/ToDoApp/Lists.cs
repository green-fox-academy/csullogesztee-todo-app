using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class Lists
    {
        //create a new list from Console
        public static List<string> HandleListFromConsol(string[] textFromConsol)
        {
            List<string> handledListFromConsol = new List<string>();

            for(int i = 1; i < textFromConsol.Length; i++)
            {
                handledListFromConsol.Add(textFromConsol[i]);
            }

            return handledListFromConsol;
        }
        
        //handle the list from file

        public List<string> ListFromFile = new List<string>();
        
        public static List<string> CreateListFromConsol(string[] textFromFile)
        {
            foreach(string element in textFromFile)
            {
                ListFromFile.Add(element);
            }

            return ListFromFile;
        }
        //modify a list from file
        //1. Add
        public static void AddElementToList(List<string> listfromconsol, List<string> listfromfile)
        {
            foreach(string line in listfromconsol)
            {
                listfromfile.Add(line);
            }
        }

        //2. Remove
        public static void RemoveElementFromList(string secondElement, List<string> listfromfile)
        {
            listfromfile.Remove((int.Parse(secondElement) - 1));
        }

        //3. AddCheck
    }
}

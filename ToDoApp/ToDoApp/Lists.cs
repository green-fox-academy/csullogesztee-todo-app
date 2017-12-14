using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class Lists
    {
        //create a new list from Console
        public List<string> HandleListFromConsol(string[] textFromConsol)
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
        
        public List<string> CreateListFromFile(string[] textFromFile)
        {
            foreach(string element in textFromFile)
            {
                ListFromFile.Add(element);
            }

            return ListFromFile;
        }
        //modify a list from file
        //1. Add
        public void AddElementToList(List<string> listfromconsol, List<string> listfromfile)
        {
            foreach(string line in listfromconsol)
            {
                listfromfile.Add(line);
            }
        }

        //2. Remove
        public List<string> RemoveElementFromList(string secondElement, List<string> listfromfile)
        {
            listfromfile.RemoveAt((int.Parse(secondElement) - 1));

            return listfromfile;
        }

        //3. AddCheck
    }
}

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
            List<string> handledList = new List<string>();

            foreach(string element in textFromConsol)
            {
                handledList.Add(element);
            }

            return handledList;
        }
        
        //handle the list from file
        //public static List<string> ListFromFile(string[] textFromFile)
        //{
        //    List<string> handledList = new List<string>();

        //    foreach (string element in textFromFile)
        //    {
        //        handledList.Add(element);
        //    }

        //    return handledList;
        //}

        //modify a list from file
        //1. Add

        //2. Remove

        //3. AddCheck
    }
}

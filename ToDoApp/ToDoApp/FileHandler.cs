﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class FileHandler
    {

        static void textcreator(List<string> addedList)
        {
            string path = 
            using (StreamWriter outputfile = new StreamWriter(path, true))
                foreach(string line in addedList)
                {
                    outputfile.WriteLine(line);
                }

        }
    }
}
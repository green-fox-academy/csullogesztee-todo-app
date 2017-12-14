using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class FileHandler
    {
        string path = @"C:\Users\Esztee\greenfox\csullogesztee-todo-app\ToDoApp\ToDoApp\bin\ToDo.txt";

        static void textreader()
        {
                string[] contentOfFile = File.ReadAllLines(path);
        }

        static void textcreator(List<string> addedList)
        {          
            using (StreamWriter outputfile = new StreamWriter(path, true))
                foreach(string line in addedList)
                {
                    outputfile.WriteLine(line);
                }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    public class FileHandler
    {
        string path = @"C:\Users\Esztee\greenfox\csullogesztee-todo-app\ToDoApp\ToDoApp\bin\Debug\ToDo.txt";

        public string[] NullReader()
        {
            string[] contentOfFile = File.ReadAllLines(@"C:\Users\Esztee\greenfox\csullogesztee-todo-app\ToDoApp\ToDoApp\bin\Debug\NullMessage.txt");

            return contentOfFile;
        }

        public string[] TextReader()
        {
            string[] contentOfFile = File.ReadAllLines(path);
            
            return contentOfFile;
        }

        public void TextCreator(List<string> addedList)
        {
            
            int counter = TextReader().Length;
            using (StreamWriter outputfile = new StreamWriter(path, true))
            foreach (string line in addedList)
            {
                counter++;
                var builtsrting = new StringBuilder(Convert.ToString(counter) + " - [ ] " + line);
                outputfile.WriteLine(builtsrting);
            }
        }

        public void TextChanger(List<string> addedList)
        {
            using (StreamWriter outputfile = new StreamWriter(path))
                foreach (string line in addedList)
                {
                    outputfile.WriteLine(line);
                }
        }
    }
}

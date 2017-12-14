using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            string[] addedtext = Console.ReadLine().Split(' ');

            var printer = new Printer();
            var fileHandler = new FileHandler();
            var lists = new Lists();

            List<string> modifiedList = new List<string>();

            //if (addedtext[] == null)
            //{
            //    printer.ListPrinter(lists.CreateListFromFile(fileHandler.NullReader()));
            //}
            if (addedtext[0] == "-l")
            {
                printer.ListPrinter(lists.CreateListFromFile(fileHandler.TextReader()));
            }
            else if (addedtext[0] == "-a")
            {
                fileHandler.TextCreator(lists.HandleListFromConsol(addedtext));
            }
            else if (addedtext[0] == "-r")
            {
                modifiedList = lists.RemoveElementFromList(addedtext[1], lists.CreateListFromFile(fileHandler.TextReader()));
                fileHandler.TextChanger(modifiedList);
            }
            else if (addedtext[0] == "-c")
            {
                modifiedList = lists.ModifiedElementFromList(addedtext[1], lists.CreateListFromFile(fileHandler.TextReader()));
                fileHandler.TextChanger(modifiedList);
            }
            
            Console.ReadLine();
        }
    }
}

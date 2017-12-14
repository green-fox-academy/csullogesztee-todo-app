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

            //if (addedtext[] == null)
            //{
            //
            //}
            if(addedtext[0] == "-l")
            {
                printer.ListPrinter(lists.CreateListFromFile(fileHandler.TextReader()));
            }
            else if(addedtext[0] == "-a")
            {
                fileHandler.TextCreator(lists.HandleListFromConsol(addedtext));
            }
            
            Console.ReadLine();
        }
    }
}

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

            //if (addedtext[] == null)
            //{
            //
            //}
            if(addedtext[0] == "-l")
            {
                Printer.ListPrinter(Lists.CreateListFromFile(FileHandler.TextReader()));
            }
            else if(addedtext[0] == "-a")
            {
                FileHandler.TextCreator(Lists.HandleListFromConsol(addedtext));
            }
            
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp
{
    class Printer
    {
        public static void ListPrinter(List<string> AnyList)
        {
            foreach (string line in AnyList)
            {
                Console.WriteLine(line);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var salmons = new List<string>();
            salmons.Add("chinook");
            salmons.Add("coho");
            salmons.Add("pink");
            salmons.Add("sockeye");

            // Iterate through the list.
            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }

            var salmons1 = new List<string> { "chinook", "coho", "pink", "sockeye" };

            // Iterate through the list.
            foreach (var salmon in salmons1)
            {
                Console.Write(salmon + " ");
            }
        }
    }
}

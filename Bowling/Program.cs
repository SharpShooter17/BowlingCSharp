using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    class Program
    {
        static void Main(string[] args)
        {
            Game g = new Game();

            g.round(1, 4);
            g.round(4, 5);
            g.round(6, 4);      // spare
            g.round(5, 5);      // spare
            g.round(10);        // strike
            g.round(0, 1);
            g.round(7, 3);      // spare
            g.round(6, 4);      // spare
            g.round(10);        // strike
            g.round(2, 8);      // spare
            g.round(6);         // rzut dodatkowy
            
            Console.ReadKey();
        }
    }
}

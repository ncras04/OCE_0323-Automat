using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automata;

namespace Getraenkeautomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automat drinkDispenser = new Automat();

            drinkDispenser.ShowDrinkList();
        }
    }
}
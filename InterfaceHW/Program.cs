using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHW
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();
            Team newteam = new Team();

            newteam.Start(house);
            Console.WriteLine();
            house.ShowHouse();
            Console.ReadLine();
        }
    }
}

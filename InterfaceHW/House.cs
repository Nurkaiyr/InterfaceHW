using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHW
{
    public class House
    {
        public List<IPart> partOfHouse;
        public House()
        {
            partOfHouse = new List<IPart>();
            IPart[] houseParts =
            {
                new Basement(),
                new Walls(),
                new Walls(),
                new Walls(),
                new Walls(),
                new Door(),
                new Window(),
                new Window(),
                new Window(),
                new Window(),
                new Roof(),
            };
            foreach (var item in houseParts)
            {
                partOfHouse.Add(item);
            }
        }

        public void ShowHouse()
        {
            Console.WriteLine("Строительство завершено!\n");
            for (int i = partOfHouse.Count - 1; i >= 0; i--)
            {
                switch (i)
                {
                    case 7:
                        Console.Write(" {0}{0}{0}{0}{0}\n" +
                            "{0}{0}{0}{0}{0}{0}{0}\n", partOfHouse[i].PrintPart());
                        break;

                    case 6:
                    case 5:
                        Console.Write("{0}", partOfHouse[i].PrintPart());
                        break;

                    case 2:
                    case 1:
                        Console.Write("{0}", partOfHouse[i].PrintPart());
                        break;

                    case 4:
                        Console.Write("{0}", partOfHouse[i].PrintPart());
                        break;

                    case 3:
                        Console.Write("{0}", partOfHouse[i].PrintPart());
                        break;

                    case 0:
                        Console.Write("\n{0}{0}{0}{0}{0}{0}{0}", partOfHouse[i].PrintPart());
                        break;
                }
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHW
{
    public class Worker:IWorker
    {
        public void Buid(IPart part)
        {
            part.Build();
        }

        public void DoWork(House house)
        {
            foreach (var part in house.partOfHouse)
                if (!part.IsBuilded()) Buid(part);
        }
    }
}

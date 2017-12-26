using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHW
{
    public class TeamLeader : IWorker
    {
        public void DoWork(House house)
        {
            int partsDone = 0;

            foreach (var part in house.partOfHouse)
                if (part.IsBuilded()) partsDone++;

            Console.WriteLine("Было построено {0} частей дома из {1}:\n", partsDone, house.partOfHouse.Count);

            foreach (var part in house.partOfHouse)
                if (part.IsBuilded()) Console.WriteLine($"\"{part.Information}\" потсроено");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHW
{
    public class Team
    {
        public List<IWorker> hunkies;

        public Team()
        {
            hunkies = new List<IWorker>();
            IWorker[] builders =
            {
                new Worker(),
                new TeamLeader(),
            };
            foreach (var worker in builders)
            {
                hunkies.Add(worker);
            }
        }

        public void Start(House house)
        {
            foreach (var hunky in hunkies)
            {
                hunky.DoWork(house);
            }
        }

    }
}

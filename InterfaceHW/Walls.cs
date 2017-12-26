﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHW
{
    public class Walls:IPart
    {
        public string Information { get; set; }

        public bool IsDone { get; set; }

        public bool IsBuilded()
        {
            return IsDone;
        }

        public void Build()
        {
            IsDone = true;
        }

        public Walls()
        {
            Information = "Стена";

            IsDone = false;
        }

        public string PrintPart()
        {
            if (IsDone) return "YES!";

            return "not yet...";
        }
    }
}

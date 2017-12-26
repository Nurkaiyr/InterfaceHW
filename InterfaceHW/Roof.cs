﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHW
{
    public class Roof:IPart
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

        public Roof()
        {
            Information = "Крыша";

            IsDone = false;
        }

        public string PrintPart()
        {
            if (IsDone) return "YES!";

            return "not yet...";
        }
    }
}

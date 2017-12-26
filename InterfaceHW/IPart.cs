using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHW
{
    public interface IPart
    {
        string Information { get; }

        bool IsBuilded();

        void Build();

        string PrintPart();
    }
}

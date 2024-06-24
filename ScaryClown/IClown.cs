using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaryClown
{
    internal interface IClown
    {
        string FunnyThingIHave { get; }
        void Honk();
    }

    internal interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittleChildren();
    }
}

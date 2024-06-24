using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaryClown
{
    internal class FunnyFunny : IClown
    {
        private string funnyThingIHave;
        public string FunnyThingIHave { get { return funnyThingIHave; } }

        public FunnyFunny(string funnyThing)
        {
            funnyThingIHave = funnyThing;
        }

        public void Honk()
        {
            Console.WriteLine($"Cześć dzieciaki! Mam {FunnyThingIHave}.");
        }
    }

    internal class ScaryScary : FunnyFunny, IScaryClown
    {
        private int scaryThingCount;
        public string ScaryThingIHave { get { return $"pająki - {scaryThingCount}";  } }

        public ScaryScary(string funnyThing, int scaryThing) : base(funnyThing)
        {
            scaryThingCount = scaryThing;
        }

        public void ScareLittleChildren()
        {
            Console.WriteLine($"Ha! Mam Was! Zobaczcie moje {ScaryThingIHave}");
        }
    }
}

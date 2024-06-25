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

        protected static Random random = new Random();
        private static int carCapacity = 12;
        public static int CarCapacity
        {
            get { return carCapacity; }
            set
            {
                if (value > 10) carCapacity = value;
                else Console.Error.WriteLine($"Uwaga! Pojemność autka {value} jest za mała!");
            }
        }

        public static string ClownCarDescription()
        {
            return $"Liczba klaunów w autku: {random.Next(CarCapacity / 2, CarCapacity)}.";
        }
    }

    internal interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittleChildren();

        void ScareAdults()
        {
            Console.WriteLine(
                $@"Jestem pradawnym złem prześladującym Cię we snach.
Spójrz na mój przerażający naszyjnik z {random.Next(4,10)} palcami moich ofiar.
A, byłbym zapomniał...");
            ScareLittleChildren();
        }
    }
}

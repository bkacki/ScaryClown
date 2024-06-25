namespace ScaryClown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IClown fingersTheClown = new ScaryScary("wielkie czerwone nosy", 14);
            fingersTheClown.Honk();
            IScaryClown iScaryClownReference = fingersTheClown as IScaryClown;
            iScaryClownReference.ScareAdults();

            Console.WriteLine();

            IClown.CarCapacity = 18;
            Console.WriteLine(IClown.ClownCarDescription());
        }
    }
}

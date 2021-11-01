

using System;

namespace pic3
{
    class Program
    {
        static void Main(string[] args)
        {
            Sizes s = new Sizes()
            {
                width = 2,
                length = 3,
                height = 1

            };

            Console.WriteLine("Volume of the given figure = " + s.VolumeOfBox(s));
        }
    }
}

using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            CD cd = new CD("CD example", 700, "CD-R", 350);
            DVD dvd = new DVD("DVD example", 4700, "DVD-R", 1450);

            cd.SpinDisc();
            dvd.SpinDisc();

            cd.ReadData();
            dvd.ReadData();

            Console.WriteLine(cd.WriteData(275));
            Console.WriteLine(dvd.WriteData(8000));

            Console.WriteLine(cd.DiskInfo());
            Console.WriteLine(dvd.DiskInfo());
        }
    }
}

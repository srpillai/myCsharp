using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc,IOpticalDisc
    {
        public DVD(string name, int maxCapacity, string disktype, int someUsedCapacity) : base(name, maxCapacity, disktype, someUsedCapacity)
        {
        }

        public void ReadData()
        {
            Console.WriteLine("I'm sorry, Dave. I'm afraid I can't do that.");
        }

        public void SpinDisc()
        {
            Console.WriteLine("A DVD spins at a rate of 570 - 1600 rpm.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class LiquidContainer<T> : Container<T>, HazardNotifier
    {
        public LiquidContainer(int Weight, int Height, int ConteinerWeight, int Depth, int MaxWeight) : base(Weight, Height, ConteinerWeight, Depth, MaxWeight)
        {
            this.Kind = 'L';

        }

        public void NotifyDanger(string mesage)
        {
            Console.WriteLine($"Dangerous situation detected in container: {mesage}");
        }
        public override unloading()
        {
            Weight = 0;
        }
        public override void loading(T cargo)
        {
            if (cargo.Amount > MaxWeight)
            {
                throw new OverfillException("Cargo weight exceeds container capacity");
            }

            if (cargo.Amount + Weight > MaxWeight * 0.5)
            {
                NotifyDanger(SerialNumber);
            }

            Weight += cargo.Amount;
        }

    }

}
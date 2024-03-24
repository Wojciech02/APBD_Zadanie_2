using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class GasContainer<T> : Container<T>, HazardNotifier
    {
        public double Pressure { get; set; }

        public GasContainer(int Weight, int Height, int ConteinerWeight, int Depth, int MaxWeight, double Pressure) : base(Weight, Height, ConteinerWeight, Depth, MaxWeight)
        {
            this.Kind = 'G';
            this.Pressure = Pressure;

    }

        public void NotifyDanger(string mesage)
        {
            Console.WriteLine($"Dangerous situation detected in container: {mesage}");
        }
        public override unloading()
        {
            Weight = Weiht * 0.05;
        }
        public override void loading(T cargo)
        {
            if (cargo.Amount > MaxWeight)
            {
                throw new OverfillException("Cargo weight exceeds container capacity");
            }

            Weight += cargo.Amount;
        }

    }

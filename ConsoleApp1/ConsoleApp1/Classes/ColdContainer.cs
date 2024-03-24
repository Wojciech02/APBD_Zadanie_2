using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public class ColdContainer<T> : Container<T>, HazardNotifier
    {
        public string ProductType { get; set; }
        public double RequiredTemperature { get; set; }

        public ColdContainer(int Weight, int Height, int ConteinerWeight, int Depth, int MaxWeight, string ProductType, double RequiredTemperature) : base(Weight, Height, ConteinerWeight, Depth, MaxWeight)
        {
            this.Kind = 'C';
            this.ProductType = ProductType;
            this.RequiredTemperature = RequiredTemperature;

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

        Weight += cargo.Amount;
    }

}
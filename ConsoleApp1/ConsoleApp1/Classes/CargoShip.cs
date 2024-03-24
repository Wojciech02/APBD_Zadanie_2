using System;
using System.Collections.Generic;

namespace ConsoleApp1.Classes
{
    public class CargoShip
    {
        public List<Container> Containers { get; set; }
        public double MaxLoad { get; set; }

        public CargoShip(double maxLoad)
        {
            Containers = new List<Container>();
            MaxLoad = maxLoad;
        }

        public void LoadContainer(Container container)
        {
            double totalWeight = 0;
            foreach (var cont in Containers)
            {
                totalWeight += cont.CurrentWeight;
            }

            if (totalWeight + container.CurrentWeight > MaxLoad)
            {
                throw new OverfillException("Cargo ship overloaded");
            }

            Containers.Add(container);
        }
    }
}
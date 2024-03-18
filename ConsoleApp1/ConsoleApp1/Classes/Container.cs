using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public abstract class Container<T>
    {
        protected Container(int Weight, int Height, int ConteinerWeight, int Depth, int MaxWeight) 
        {
            this.Weight = Weight;
            this.Height = Height;
            this.Depth = Depth;
            this.MaxWeight = MaxWeight;

        }

        public int Weight { get; set; }
        public int Height { get; set; }
        public int ConteinerWeight { get; set; }
        public int Depth { get; set; }

        public int MaxWeight { get; set; }

        public abstract void unloading();

        public abstract void loading(T cargo);

        public string _SerialNumber { get; set; } 

        public string SerialNumber
        {

            get
            {
                return this._SerialNumber;
            }
            set
            {
                _SerialNumber = $"KON-C-{SerialNumber.GenerateUniqueId()}";
            }
        }

    }
}

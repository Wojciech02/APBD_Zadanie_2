using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public abstract class Cargo
    {
        protected Cargo(String name, int amount)
        {
            Name = name;
            Amount = amount;
        }
        public String Name { get; protected set;}
        public int Amount { get; protected set;}
    }
}

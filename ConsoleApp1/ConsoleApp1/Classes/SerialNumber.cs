using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    public static class SerialNumber
    {
        public static List<int> SerialNumbers { get; set; } = new();

        public static int GenerateUniqueId()
        {
            if (SerialNumbers.Count == 0) 
            {

                SerialNumbers.Add(0);
                return 0;

            }

            var number = SerialNumbers.Last() + 1;
            SerialNumbers.Add(number);
            return number;
        }
    }
}

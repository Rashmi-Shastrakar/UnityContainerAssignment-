using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityCountainerAssignment.Interfaces;

namespace UnityCountainerAssignment.Class
{
    class Laptop : ILaptops
    {
        public void Rates()
        {
            Console.WriteLine("Laptops Price= 50000");
        }
    }
}

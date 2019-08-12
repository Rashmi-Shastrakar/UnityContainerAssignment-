using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityCountainerAssignment.Interfaces;

namespace UnityCountainerAssignment.Class
{
    class Iphone : IMobiles
    {
        public void Price()
        {
            Console.WriteLine("Iphone Price : 80000");
        }
    }
}

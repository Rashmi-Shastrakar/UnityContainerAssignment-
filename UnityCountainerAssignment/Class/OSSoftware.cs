using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using UnityCountainerAssignment.Interfaces;

namespace UnityCountainerAssignment.Class
{
    class OSsoftware
    {
        private ILaptops _laptops;
        [Dependency]
        public ILaptops Laptops
        {
            get { return _laptops; }
            set { _laptops = value; }
        }
        public void TotalCost()
        {
            _laptops.Rates();
            Console.WriteLine("Software Cost = 5000");
        }
    }
}

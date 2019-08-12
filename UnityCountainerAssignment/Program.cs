using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using UnityCountainerAssignment.Class;
using UnityCountainerAssignment.Interfaces;
using Unity.Injection;
namespace UnityCountainerAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer unitycontainer = new UnityContainer();
             unitycontainer.RegisterType<ILaptops, Laptop>();

            OSsoftware os = unitycontainer.Resolve<OSsoftware>();
            os.TotalCost();

            unitycontainer.RegisterType<IMobiles, Iphone>("iphone");
            unitycontainer.RegisterType<IMobiles, OnePlus>("oneplus");


            IMobiles iphone = unitycontainer.Resolve<IMobiles>("iphone");
            IMobiles onePlus = unitycontainer.Resolve<IMobiles>("oneplus");
            IMobiles abc=unitycontainer.Resolve<IMobiles>(new Depe)
            iphone.Price();
            onePlus.Price();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FirstCourseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animalList = new Animal[]
            {
                new Animal{name = "pisica", sound = "miau"},
                new Animal{name = "caine", sound = "ham"},
                new Animal{name = "urs", sound = "moor"},
                new Animal{name = "dragon", sound = "wooooo"},
                new Animal{name = "sarpe", sound = "ssss"}
            };

            foreach(Animal element in animalList)
            {
                Console.WriteLine(element.name + " makes " + element.sound);
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleLSP.TheBad;

namespace ExampleLSP
{
    class Program
    {
        static void Main(string[] args)
        {
            //The bad way
            List<TheBad.Dog> listDogs = new List<TheBad.Dog>();
            listDogs.Add(new TheBad.Dog5kg());
            listDogs.Add(new TheBad.Dog5_10kg());
            listDogs.Add(new TheBad.Cat());

            //The good way
            List<TheGood.Dog> list = new List<TheGood.Dog>();
            list.Add(new TheGood.Dog20kg());
            list.Add(new TheGood.Dog5kg());
            //Now the compiler will refuse to go along with this next line
            list.Add(new TheGood.Cat());

        }
    }
}

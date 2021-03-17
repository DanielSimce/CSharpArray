using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    
    {
        static void Main(string[] args)
        {
            string[] cars = { "volvo", "BMW", "Ford", "Mazda" };
            int[] myNum = { 10, 20, 30, 40 };

            string[] car = new string[4];



            Console.WriteLine(cars[0]);

            cars[0] = "Jeep Suziki";

            Console.WriteLine(cars[0]);
            Console.WriteLine(cars.Length);

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(myNum.Max());
            Console.WriteLine(myNum.Min());
            Console.WriteLine(myNum.Sum());
            

            Console.ReadLine();
        }
    }
}

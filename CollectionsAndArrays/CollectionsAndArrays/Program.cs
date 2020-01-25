using System;
using System.Collections.Generic;

namespace CollectionsAndArrays
{
    class MainClass
    {
        //Store and display collection of strings

        public static void Main(string[] args)
        {
            #region Collections
            Console.WriteLine("1- Collections section: ");

            var cars = new List<string>();

            //Store names of cars in the collection
            cars.Add("BMW");
            cars.Add("Merceds");
            cars.Add("Wolksvagen");

            //1- display each element by its position in the collection "index"
            Console.WriteLine("\nUsing single index indication =>");
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);

            //2- move through the collection by the elements
            Console.WriteLine("\nUsing for loop by element =>");
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

            //3- move through the collection by the index of elements
            Console.WriteLine("\nUsing for loop by index =>");
            for (var index = 0; index < cars.Count; ++index)
            {
                Console.WriteLine(cars[index]);
            }
            #endregion


            #region Arrays
            Console.WriteLine("\n2- Arrays section: ");

            int[] gearNumber = new int[] { 6, 6, 5 };

            for(var count = 0; count < gearNumber.Length; ++count)
            {
                Console.WriteLine(cars[count] + " gear: " + gearNumber[count]);
            }
            #endregion
        }
    }
}

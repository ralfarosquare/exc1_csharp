using System;
using System.Collections.Generic;
using System.Linq;


    namespace Class2

    {

        class Program

        {

            static void Ma(string[] args)

            {

                //Print First Five Values

                int[] integerList = { 9, 8, 7, 6, 5, 4, 3, 2 };



                IEnumerable<int> firstFive = integerList.OrderByDescending(item => item).Take(5);



                Console.WriteLine("The first five values are:");

                foreach (int item in firstFive)

                {

                    Console.WriteLine(item);

                }



                //PrintSmallestNumber

                int[] arrayList = new int[7] { 20, 400, 40, 50, 10, 1, 4000 };

                int smallest = arrayList[0];

                for (int i = 0; i < arrayList.Length; i++)

                {

                    if (arrayList[i] < smallest)

                        smallest = arrayList[i];

                }

                Console.WriteLine("The smallest number of the array is:" + smallest);



                //Print Dictionary 

                Dictionary<String, int> myDictionary = new Dictionary<string, int>

            {

                { "Sunday", 1 },

                { "Monday", 2 },

                { "Tuesday", 3 },

                { "Wednesday", 4 },

                { "Thursday", 5 },

                { "Friday", 6 },

                { "Saturday", 6 }

            };



                foreach (KeyValuePair<String, int> entry in myDictionary)

                {

                    Console.WriteLine(entry.Key + " : " + entry.Value);

                }

            }







        }

    }

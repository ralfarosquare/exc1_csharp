using System;

namespace exc1_csharp
{
    class Program

    {

        static void Main(string[] args)

        {

            // String  Comparison 

            string firstName = "Rodrigo";

            string lastName = "Alfaro";





            if (firstName == lastName)

            {

                Console.WriteLine("Both strings are the same");

            }

            else

            {

                Console.WriteLine("Are different strings");

            }



            // Biggest Number

            int[] array1 = new int[5] { 1, 3, 10, 7, 9 };

            Array.Sort(array1);

            Console.WriteLine("The biggest number is:  " + array1[4]);



            //sort List

            int[] sortarray = new int[6] { 100, 200, 500, 700, 900, 1000 };

            Console.Write("List: ");

            foreach (int i in sortarray)

            {

                Console.Write(i + " ");

            }

            Console.WriteLine();

            Console.Write("Sorted List: ");

            Array.Sort(sortarray);

            foreach (int desc in sortarray)

            {

                Console.WriteLine(desc);

            }



            // Count String length



            string name = "Unosquare";

            int nameLength = name.Length;

            Console.WriteLine("The name  of the string contains " + nameLength + " " + "letters");

        }





    }



}






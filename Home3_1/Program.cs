using System;
using System.ComponentModel.Design;
using System.Diagnostics.Tracing;
using System.Net.Http.Headers;
using System.Security;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
              Task1();
            //  Task2();
            //  Task3();
            //  Task4();
            //  Task5();
            // Task5S();
            //Task6();
            //Task8();
            // Task9();
            //Task10();
           // Task11();
        }
        public static void Task1()
        {
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int)random.NextInt64(1, 50);
                Console.Write(array[i] + "  ");
            }
            Console.WriteLine();

            Console.Write("Input value:");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                { Console.WriteLine("Value " + number + " exist in array.Its position " + (i + 1)); }
            }
        }
        public static void Task2()
        {
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int)random.NextInt64(1, 50);
                Console.Write(array[i] + "  ");
            }
            Console.WriteLine();

            Console.Write("Input value:");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                { continue; }
                Console.Write(array[i] + "  ");
                //   
                // else { Console.Write("The value "+number+"is apsent in array"); }
            }
        }

        public static void Task3()
        {
            Console.Write("Input length array:");
            int n = int.Parse(Console.ReadLine());

            Random random = new Random();
            int[] array = new int[n];


            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int)random.NextInt64(1, 50);
                Console.Write(array[i] + "  ");
            }
            Console.WriteLine();

            double relustsi = 0;
            for (int i = 0; i < array.Length; i++)
            {
                relustsi += array[i];
            }
            double resulta = relustsi / array.Length;
            Console.WriteLine("Average: " + resulta);

            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("max=" + max);

            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("min=" + min);
        }
        public static void Task4()
        {
            Console.Write("Input length array:");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];


            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Input array value " + i + " = ");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + "  ");
            }

            Console.WriteLine();

            double relustsi = 0;
            for (int i = 0; i < array.Length; i++)
            {
                relustsi += array[i];
            }
            double resulta = relustsi / array.Length;
            Console.WriteLine("Average: " + resulta);

            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("max=" + max);

            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("min=" + min);
        }
        public static void Task5()
        {
            Random random = new Random();
            int[] array1 = new int[5];
            int[] array2 = new int[5];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = (int)random.NextInt64(1, 50);
                Console.Write(array1[i] + "  ");
            }
            Console.WriteLine();

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = (int)random.NextInt64(1, 50);
                Console.Write(array2[i] + "  ");
            }
            Console.WriteLine();

            double relustsi1 = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                relustsi1 += array1[i];
            }
            double resulta1 = relustsi1 / array1.Length;
            Console.WriteLine("Average first array: " + resulta1);

            double relustsi2 = 0;
            for (int i = 0; i < array2.Length; i++)
            {
                relustsi2 += array2[i];
            }
            double resulta2 = relustsi2 / array2.Length;
            Console.WriteLine("Average second array: " + resulta2);

            if (resulta1 < resulta2)
            { Console.WriteLine("Average second array is biggest than average first array "); }
            else if (resulta1 > resulta2)
            { Console.WriteLine("Average first array is biggest than average second array "); }
            else { Console.WriteLine("Average first array equal average second array "); }
        }
        public static void Task6()
        {
            Random random = new Random();
            int[] array = new int[10];
            //  array[] = (int)random.NextInt64(1, 5);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int)random.NextInt64(1, 50);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                { array[i] = 0; }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        public static void Task8()
        {
            Random random = new Random();
            int[] array = new int[10];
            //  array[] = (int)random.NextInt64(1, 5);
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int)random.NextInt64(1, 50);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            int k = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        k = array[i];
                        array[i] = array[j];
                        array[j] = k;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        public static void Task9()
        {
            Random random = new Random();
            int[,] array = new int[5, 5];
            //  array[] = (int)random.NextInt64(1, 5);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = (int)random.NextInt64(1, 5);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];

                }
            }
            Console.WriteLine("Summ is equal= " + sum);
        }
        public static void Task10()
        {
            Random random = new Random();
            int[,] array = new int[5, 5];
            //  array[] = (int)random.NextInt64(1, 5);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = (int)random.NextInt64(1, 5);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                    { Console.WriteLine(array[i, j]); }

                }
            }

            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i + j == array.GetLength(0) - 1)
                    { Console.WriteLine(array[i, j]); }
                }
            }
        }
        public static void Task11()
        {
            int n1;
            Console.Write("Input length array(5<array<=10):");
            int n = int.Parse(Console.ReadLine());

            Random random = new Random();
            int[] array = new int[n];
            int[] array2 = new int[n];

            if ((n > 5) && (n <= 10))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = (int)random.NextInt64(1, 50);
                    Console.Write(array[i] + "  ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.Write("Error! Try again:");
                n1 = int.Parse(Console.ReadLine());
                int[] array1 = new int[n1];

                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = (int)random.NextInt64(1, 50);
                    Console.Write(array1[i] + "  ");
                }
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                { array2[i] = array[i]; }
            }
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + "  ");
            }
        }
        public static void Task5S()
        {
            Random random = new Random();
            string[] names = new string[] { "ivan", "nikolay", "alex", "oleg", "zina", "elena", "artem" };

            Array.Sort(names, StringComparer.CurrentCultureIgnoreCase);
            Console.WriteLine(String.Join(", ", names));
        }
    }

}
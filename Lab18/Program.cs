using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFirst(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list.ElementAt(i));
            }

            bool validIndex = list.RemoveAt(7);
            //bool validIndex = list.InsertAt(2, 20);
            Console.WriteLine("");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list.ElementAt(i));
            }

            Console.WriteLine(validIndex);
            list.PrintReverse();

            int[] numArray = { 1, 2, 3, 2, 2, 4, 5, 5, 7, 8, 4, 4, 1, 0, 10 };
            Console.WriteLine("Frequency using Array");
            ArrayFrequency(numArray);
            Console.WriteLine("Frequency using Dictonary");
            DictionaryFequency(numArray);

            Console.ReadKey();
        }

        public static void ArrayFrequency(int[] intArray)
        {
            int big = intArray.Max();

            int[] frequencyArray = new int[big + 1];

            for (int i = 0; i < frequencyArray.Length; i++)
            {
                for (int j = 0; j < intArray.Length; j++)
                {
                    if (intArray[j] == i)
                    {
                        frequencyArray[i]++;
                    }
                }
            }
            for (int i = 0; i < frequencyArray.Length; i++)
            {
                if (frequencyArray[i] > 0)
                {
                    Console.WriteLine($"[{i}]: {frequencyArray[i]}");
                }
            }
        }

        public static void DictionaryFequency(int[] intArray)
        {
            Dictionary<int, int> list = new Dictionary<int, int>();

            foreach (int num in intArray)
            {
                if (list.ContainsKey(num))
                {
                    list[num]++;
                }
                else
                {
                    list.Add(num, 1);
                }
            }
            foreach (var item in list.OrderBy(key => key.Key))
            {
                Console.WriteLine($"[{item.Key}]: {item.Value}");
            }
        }
    }

}

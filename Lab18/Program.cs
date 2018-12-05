using System;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            /***********************************
             * LinkedList methods***************
             * *********************************
             
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

            //bool validIndex = list.RemoveAt(7);
            bool validIndex = list.InsertAt(2, 20);
            Console.WriteLine("");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list.ElementAt(i));
            }

            Console.WriteLine(validIndex);
            //list.PrintReverse();
            *********************************************/

            int[] numArray = { 1, 2, 3, 2, 2, 4, 5, 5, 7, 8, 4, 4, 1, 0, 10 };

            ArrayFrequency(numArray);

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
                    Console.Write($"[{i}]: ");
                    Console.WriteLine(frequencyArray[i]);
                }
            }
        }

    }

}

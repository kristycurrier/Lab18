using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab18
{
    public static class LinkedListExtensions
    {
        public static bool RemoveAt<t>(this LinkedList<t> list, int index)
        {
            var length = list.Count;
            var boolValue = false;
            if (index >= length)
            {
                boolValue = false;
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    if (i != index)
                    {
                        list.AddLast(list.ElementAt(i));
                    }
                }
                for (int i = 0; i < length; i++)
                {
                    list.RemoveFirst();
                }
                boolValue = true;
            }
            return boolValue;
        }

        public static void PrintReverse<t>(this LinkedList<t> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(list.ElementAt(i));
            }
        }

        public static bool InsertAt<t>(this LinkedList<t> list, int index, t o)
        {
            var length = list.Count;
            var boolValue = false;
            if (index >= length)
            {
                boolValue = false;
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    if (i == index)
                    {
                        list.AddLast(o);
                    }
                    list.AddLast(list.ElementAt(i));
                }
                for (int i = 0; i < length; i++)
                {
                    list.RemoveFirst();
                }
                boolValue = true;
            }
            return boolValue;
        }

    }

}

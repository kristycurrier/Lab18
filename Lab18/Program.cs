﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                bool validIndex = list.RemoveAt(10);
                Console.WriteLine("");

                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list.ElementAt(i));
                }

                Console.WriteLine(validIndex);

                Console.ReadKey();
            }
        }
    }
}
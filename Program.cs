using System;
using System.Collections.Generic;
using System.Linq;

namespace UG_CSHARP_PK
{
    class Program
    {
        static void Main(string[] args)
        {
            NumbersGenerator[] nums = new NumbersGenerator[3];
            nums[0] = new NumbersGenerator(10000);
            nums[1] = new NumbersGenerator(100000);
            nums[2] = new NumbersGenerator(200000);

            foreach (NumbersGenerator num in nums)
            {
                Dictionary<String, long> dict = new Dictionary<string, long>();
                int[] numbers = num.GetNumbers();
                int length = numbers.Length;
                long time;
                string sort;

                SelectSort ss = new SelectSort(numbers);
                time = ss.GetTime();
                sort = ss.GetType().Name;
                dict.Add(sort, time);
                print(sort, length, time);

                BubbleSort bs = new BubbleSort(numbers);
                time = bs.GetTime();
                sort = bs.GetType().Name;
                dict.Add(sort, time);
                print(sort, length, time);

                QuickSort qs = new QuickSort(numbers);
                time = qs.GetTime();
                sort = qs.GetType().Name;
                dict.Add(sort, time);
                print(sort, length, time);

                string best = dict.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;
                Console.WriteLine("***\t" + best + " was first with " + dict[best] + " ms." + "\t***\n\n");
            }

            void print(string s, int i, long l) => Console.WriteLine(s + " sorted " + i + " integers in " + l + " ms." + "\n");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace UG_CSHARP_PK
{
    public class NumbersGenerator
    {
        private int[] arr;
        public NumbersGenerator(int i)
        {
            IEnumerable<int> nums = Enumerable.Range(1, i);
            this.arr = nums.ToArray();
            Randomize(this.arr);
        }

        private Random Rand = new Random();
        private void Randomize(int[] arr)
        {
            int length = this.arr.Length;
            for (int i = 0; i < length; i++)
            {
                int temp = arr[i];
                int j = Rand.Next(i, length);
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        public int[] GetNumbers() => this.arr;

        public override string ToString() => string.Join("\n", this.arr);
    }
}
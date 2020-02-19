using System;
using System.Diagnostics;

namespace UG_CSHARP_PK
{
    public class ParentSort
    {
        public int[] arr;
        private Action a;
        public ParentSort(int[] arr)
        {
            this.arr = new int[arr.Length];
            arr.CopyTo(this.arr, 0);
            this.a = () => Sort();
        }

        public virtual void Sort() => Console.WriteLine("\t...sorting with " + this.GetType().Name + "...");

        public void Swap(int i, int j)
        {
            int temp = this.arr[i];
            this.arr[i] = this.arr[j];
            this.arr[j] = temp;
        }

        public virtual long Stopper(Action action)
        {
            Stopwatch sw = Stopwatch.StartNew();
            action();
            return sw.ElapsedMilliseconds;
        }

        public long GetTime() => Stopper(a);

        public override string ToString() => string.Join("\n", this.arr);
    }
}
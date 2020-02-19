namespace UG_CSHARP_PK
{
    public class SelectSort : ParentSort
    {
        public SelectSort(int[] arr) : base(arr) { }
        public override void Sort()
        {
            base.Sort();
            int i, j, min;
            for (i = 0; i < this.arr.Length; i++)
            {
                min = i;
                for (j = 0; j < this.arr.Length; j++)
                {
                    if (this.arr[j] > this.arr[min])
                    {
                        min = j;
                        Swap(i, min);
                    }
                }
            }
        }
    }
}
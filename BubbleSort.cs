namespace UG_CSHARP_PK
{
    public class BubbleSort : ParentSort
    {
        public BubbleSort(int[] arr) : base(arr) { }
        public override void Sort()
        {
            base.Sort();
            foreach (int i in this.arr)
            {
                for (int j = 0; j < this.arr.Length - 1; j++)
                {
                    if (this.arr[j] > this.arr[j + 1])
                    {
                        Swap(j, j + 1);
                    }
                }
            }
        }  
    }
}
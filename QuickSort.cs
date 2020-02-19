namespace UG_CSHARP_PK
{
    public class QuickSort : ParentSort
    {
        public QuickSort(int[] arr) : base(arr) { }
        public override void Sort()
        {
            base.Sort();
            QuickSort(this.arr, 0, this.arr.Length - 1);

            void QuickSort(int[] arr, int l, int r)
            {
                int i;
                if (l < r)
                {
                    i = Partition(arr, l, r);
                    QuickSort(arr, l, i - 1);
                    QuickSort(arr, i + 1, r);
                }
            }

            int Partition(int[] arr, int l, int r)
            {
                int i = l - 1,
                    x = arr[r];

                for (int j = l; j <= r - 1; j++)
                {
                    if (arr[j] <= x)
                    {
                        i++;
                        Swap(i, j);
                    }
                }

                Swap(i + 1, r);
                return i + 1;
            }
        }
    }
}
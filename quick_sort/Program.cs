int[] QuickSort(int [] arr)
{
    if (arr.Length <= 1)
        return arr;

    else 
    {
        int pivot = arr[0];
        int[] left = arr.Skip(1).Where(x => x < pivot).ToArray();
        int[] right = arr.Skip(1).Where(x => x >= pivot).ToArray();
        return QuickSort(left).Concat(new int[] {pivot}).Concat(QuickSort(right)).ToArray();
    }
}

int [] arr = {3, 1, 4, 5, 9 ,2, 7, 6, 4, 8};
int[] arr_result = QuickSort(arr);

foreach (var item in arr_result)
{
    Console.Write($"{item} ");
}

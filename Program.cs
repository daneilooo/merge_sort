﻿int[] ints = { 8, 875, 7, 9, 764, 55 };

Console.WriteLine("Original array:");
for (int i = 0; i < ints.Length; i++)
{
    if (i == ints.Length - 1)
    {
        Console.Write(ints[i]);
        break;
    }
    Console.Write(ints[i]+",");
}



Console.WriteLine();
MergeSort(ints);
Console.WriteLine("------------------------------");
Console.WriteLine("Sorted array:");

for (int i = 0; i < ints.Length; i++)
{
    if (i == ints.Length - 1)
    {
        Console.Write(ints[i]);
        break;
    }
    Console.Write(ints[i] + ",");
}
// making array in two parts
int [] MergeSort(int[] arr)
{
    int[] bad = new int[0];
    if (arr.Length <= 1)
        return null;

    int mid = arr.Length / 2;

    int[] left = new int[mid];
    int[] right = new int[arr.Length - mid];

    for (int i = 0; i < mid; i++)
        left[i] = arr[i];

    for (int i = mid; i < arr.Length; i++)
        right[i - mid] = arr[i];

    MergeSort(left);
    MergeSort(right);

    Merge(arr, left, right);
    return null;
}
// main sort
int [] Merge(int[] arr, int[] left, int[] right)
{
    int i = 0, j = 0, k = 0;

    while (i < left.Length && j < right.Length)
    {
        if (left[i] <= right[j])
            arr[k++] = left[i++];
        else
            arr[k++] = right[j++];
    }

    while (i < left.Length)
        arr[k++] = left[i++];

    while (j < right.Length)
        arr[k++] = right[j++];

  
    return arr;
}

  
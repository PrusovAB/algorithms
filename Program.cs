using Sorts;

int[] arr = new int[] { 6, 3, 9, 1, 0, -10, 2, 7 };

Console.WriteLine(string.Join(", ", arr));

int[] arrayForSort = new int[arr.Length];
arr.CopyTo(arrayForSort, 0);


SortsInt.QuickSort(arrayForSort);

Console.WriteLine(string.Join(", ", arrayForSort));

Console.ReadLine();
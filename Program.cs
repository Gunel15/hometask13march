
int[] arr = { 1, 2, 3, 4, 5, 6, };int min = arr[0];int max = arr[0];int sum;
for (int i = 0; i < arr.Length; i++)
    if (arr[i] < min)
    { min = arr[i]; }
for (int j = 0; j < arr.Length; j++)
if (max < arr[j])
{ max = arr[j]; }
{ sum = min + max; }
{ Console.WriteLine(sum); }    




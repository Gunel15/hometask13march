
//int[] arr = { 1, 2, 3, 4, 5, 6, }; int min = arr[0]; int max = arr[0]; int sum;
//for (int i = 0; i < arr.Length; i++)
//    if (arr[i] < min)
//    { min = arr[i]; }
//for (int j = 0; j < arr.Length; j++)
//    if (max < arr[j])
//    { max = arr[j]; }
//{ sum = min + max; }
//{ Console.WriteLine(sum); }  task 3


//int[] arr = { 1, 2, 3, 4, 5, 9 };int result=0;
//for (int i = 0; i < arr.Length; i++)
//    if (arr[i] % 2 != 0 && arr[i] % 3 == 0)
//    {  result++; }
//    { Console.WriteLine(result++); } task 4


//int num = 196451, max = 0, reqem;
//while (num > 0)
//{ reqem = num % 10;
//    if (reqem >= max)
//        max = reqem;
//     num = num / 10;}
//{ Console.WriteLine(max); } task 1


//int num = 64;
//if (num % 2 == 0)
//{ num = num / 2;
// Console.WriteLine("2-nin quvvetidir"); }
//else { Console.WriteLine("2-nin quvveti deyil"); }


using System.ComponentModel.Design;

//int num=2;int count = 0;
//for (int i = 2; i <= num / 2; i++)
// if (num % i == 0)
//     count++;
//if (count >= 1)
//    Console.WriteLine("eded murekkebdir");
//else Console.WriteLine("eded sadedir");


int[] arr = { 1, 2, 4, 6, 78, 34, 23, 11 }; int countm = 0;

for (int i = 0; i < arr.Length; i++)

{
    int count = 0;
    for (int j = 2; j <= arr[i] / 2; j++)
    {
        if (arr[i] % j == 0)
        { count++; }
    }
    {
        if (count >= 1)
        {
            countm++;
           
        }
    }
}
Console.WriteLine(countm);     
    






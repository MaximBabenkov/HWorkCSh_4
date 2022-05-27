// Задать массив, заполнить случайными положительными трехзначными числами
// Показать количество нечетных/четных чисел 
int[]arr = new int[6];
for (int i=0;i<arr.Length;i++)
{
    arr[i]=new Random().Next(100,1000);
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();
int unev=0;
int ev=0;
for (int i=0;i<arr.Length;i++) 
{
    if (arr[i]%2!=0) unev=unev+1;
    else if (arr[i]%2==0)  ev=ev+1;
}
Console.Write($"The amount of uneven numbers: {unev}");
Console.WriteLine();
Console.Write($"The amount of even numbers: {ev}");

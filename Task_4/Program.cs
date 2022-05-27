// В одномерном массиве из 123 чисел
// найти количество элементов из отрезка [10,99]
int[]arr = new int[123];
for (int i=0;i<arr.Length;i++)
{
    arr[i]=new Random().Next(0,1000);
    Console.Write($"{arr[i]} ");
}
int sum=0;
Console.WriteLine();
for (int i=0;i<arr.Length;i++) 
{
    if (arr[i]>=10 && arr[i]<=99) sum=sum+1;
}
Console.Write($"The amount of numbers from range [10,99]: {sum}");

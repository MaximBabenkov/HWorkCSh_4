// Задать массив из 12 элементов, заполнить числами из [-9,9]
// Найти сумму положительных/отрицательных элементов
int[]arr = new int[12];
for (int i=0;i<arr.Length;i++)
{
    arr[i]=new Random().Next(-9,9);
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();
int sumPos=0;
int sumNeg=0;
for (int i=0;i<arr.Length;i++)
{
    if (arr[i]>0)  sumPos=sumPos+arr[i];
    else if (arr[i]<0) sumNeg=sumNeg+arr[i];
}
Console.Write($"The sum of positive numbers: {sumPos}");
Console.WriteLine();
Console.Write($"The sum of negative numbers: {sumNeg}");

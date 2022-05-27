// Найти произведения пар чисел в одномерном массиве
// Парой считаются первый и последний элементы, второй и предпоследний и т.д.
int[]arr = new int[8];
for (int i=0;i<arr.Length;i++)
{
    arr[i]=new Random().Next(0,9);
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();
int iStart=0;
int iFin=arr.Length-1;
while(iStart<=iFin)
{
    Console.Write($"{arr[iStart]*arr[iFin]} ");
    iStart++;
    iFin--;
}

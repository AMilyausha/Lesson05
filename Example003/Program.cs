// Задача 3*: Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int[] array = {1,7,22,2,78};
int min=array[1];
int max=0;
int n=5;

for (int i=0; i<n;i++)
{
    if (array[i]>max)
    {
        max=array[i];
    }
}
Console.WriteLine(max);

for (int i=0; i<n;i++)
{
    if (array[i]<min)
    {
        min=array[i];
    }
}
Console.WriteLine(min);
int result =max-min;
Console.WriteLine(result);
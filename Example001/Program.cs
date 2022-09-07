// Задача 1: 
// Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
int N=5;
int[] array = new int [N]; 
for (int i=0;i<N;i++)
{
    array[i]=new Random().Next(100,1000);
    Console.WriteLine(array[i]+ ",");
}
int count=0;
for (int i=0;i<N;i++)
{
   if (array[i] %2==0)
{
    count++;   
}
}
Console.WriteLine("Количество четных чисел равно:" + count);

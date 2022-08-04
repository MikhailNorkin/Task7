/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

int m = 0;
int n = 0;

Console.WriteLine("Введите количество строк массива:");
m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
n = int.Parse(Console.ReadLine());

int[,] array = new int[m,n];

for (int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next(10);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}


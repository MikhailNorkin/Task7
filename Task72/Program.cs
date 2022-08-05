/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
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

int p = 0;
Console.WriteLine("Введите число, которе необходимо проверить:");
p = int.Parse(Console.ReadLine());

for (int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        if (array[i,j] == p)
        {
            Console.WriteLine("Такое число есть в массиве!");
            return;

        }
    }
}
Console.WriteLine("Такого числа нет в массиве!");
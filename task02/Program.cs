//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//17 -> такого числа в массиве нет

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{ inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int getSearch(int[,] ar, int a, int b)
{
    int prov = 0;
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++)
        {
            if (i == a && j == b)
            {
                prov = ar[i, j];
                break;
            }
        }
    }
    if (prov > 0)
    {
        Console.WriteLine($"{prov} присутствует в массиве");
    }
    else Console.WriteLine(" такого числа в массиве нет ");
    return a;
}


Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

Console.Write("Введите позицию 1 ");
int count1 = int.Parse(Console.ReadLine());

Console.Write("Введите позицию 2: ");
int count2 = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
getSearch(array, count1, count2);
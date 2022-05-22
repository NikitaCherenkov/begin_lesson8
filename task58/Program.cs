// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

var rand = new Random();
Console.WriteLine("Введите количество строк матриц");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матриц");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array0 = new int[line, column];
int[,] array1 = new int[line, column];
Console.WriteLine("Выберите способ заполнения матриц:");
Console.WriteLine("1 - вручную, 2 - случайными целыми числами");
var mode = Convert.ToInt32(Console.ReadLine());
if (mode == 1)
{
    for (int k = 0; k < line; k++)
    {
        Console.WriteLine($"Заполните {k + 1} строку первой матриы");
        for (int i = 0; i < column; i++)
        {
            Console.WriteLine($"Введите элемент {i + 1}");
            array0[k, i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    for (int k = 0; k < line; k++)
    {
        Console.WriteLine($"Заполните {k + 1} строку второй матрицы");
        for (int i = 0; i < column; i++)
        {
            Console.WriteLine($"Введите элемент {i + 1}");
            array1[k, i] = Convert.ToInt32(Console.ReadLine());
        }
    }
}
else if (mode == 2)
{
    Console.WriteLine("Введите диапазон случайных чисел");
    Console.WriteLine("Пример ввода для диапазона от 1 до 100: \"1 100\"");
    int[] entry = Console.ReadLine().Split().Select(int.Parse).ToArray();
    for (int k = 0; k < line; k++)
    {
        for (int i = 0; i < column; i++)
        {
            array0[k, i] = rand.Next(entry[0], entry[1] + 1);
            array1[k, i] = rand.Next(entry[0], entry[1] + 1);
        }
    }
}
Console.WriteLine();
Console.WriteLine("Исходные матрицы:");
Console.WriteLine();
for (int i = 0; i < line; i++)
{
    for (int l = 0; l < column; l++)
    {
        Console.Write($"{array0[i, l]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < line; i++)
{
    for (int l = 0; l < column; l++)
    {
        Console.Write($"{array1[i, l]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Результат:");
Console.WriteLine();
int[,] array2 = new int[line, column];
for (int i = 0; i < line; i++)
{
    for (int l = 0; l < column; l++)
    {
        array2[i, l] = array0[i, l] * array1[i, l];
        Console.Write($"{array2[i, l]} ");
    }
    Console.WriteLine();
}

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

var rand = new Random();
Console.WriteLine("Введите количество строк массива");
int line = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива");
int column = Convert.ToInt32(Console.ReadLine());
while (!rectangle(line, column))
{
    Console.WriteLine("Введён не прямоугольный массив");
    Console.WriteLine("Введите количество строк массива");
    line = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов массива");
    column = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
int[,] array = new int[line, column];
Console.WriteLine("Выберите способ заполнения массива:");
Console.WriteLine("1 - вручную, 2 - случайными целыми числами");
var mode = Convert.ToInt32(Console.ReadLine());
if (mode == 1)
{
    for (int k = 0; k < line; k++)
    {
        Console.WriteLine($"Заполните {k + 1} строку массива");
        for (int i = 0; i < column; i++)
        {
            Console.WriteLine($"Введите элемент {i + 1}");
            array[k, i] = Convert.ToInt32(Console.ReadLine());
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
            array[k, i] = rand.Next(entry[0], entry[1] + 1);
        }
    }
}
Console.WriteLine();
Console.WriteLine("Исходный массив:");
Console.WriteLine();
for (int i = 0; i < line; i++)
{
    Console.Write($"Строка {i + 1}:  ");
    for (int l = 0; l < column; l++)
    {
        Console.Write($"{array[i, l]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.Write("Строка с наименьшей суммой элементов: ");
int[] temp = new int[line];
for (int l = 0; l < line; l++)
{
    for (int c = 0; c < column; c++)
    {
        temp[l] += array[l, c];
    }
}
int num = 1;
int tmp = temp[0];
for (int i = 0; i < line; i++)
{
    if (temp[i] < tmp) num = i + 1;
}
Console.Write(num);
bool rectangle(int a, int b)
{
    if (a == b)
    {
        return false;
    }
    else
    {
        return true;
    }
}
/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.*/


int[] array = GetArray(12, 100, 999);

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

Console.Write("[ ");
foreach (int i in array)
{
    Console.Write(i + " ");
}
Console.Write("]");

int GetEvenNumbers(int [] ar)
{
    int j = 0;
    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i] % 2 == 0) j++;
    }
    return j;
}

Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве = {GetEvenNumbers(array)}");

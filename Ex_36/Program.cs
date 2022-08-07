/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.*/

int[] array = GetArray(10, -1000, 1000);
int sum = 0;

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

int GetSum(int[] array)
{
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
return sum;
}

Console.WriteLine();
Console.WriteLine($"Сумма стоящих на нечётных позициях чисел в массиве = {GetSum(array)}");

/*Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.*/

double[] array = GetArray(12, -100, 100);
double maxNum = array[0];
double minNum = array[0];

double[] GetArray(int size, int min, int max)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

Console.Write("[ ");
foreach (double i in array)
{
    Console.Write(i + " ");
}
Console.Write("]");
Console.WriteLine();

double GetDifference(double [] ar)
{
    for (int i = 1; i < array.Length; i++)
    {
        if (maxNum < array[i]) maxNum = array[i];
        if (minNum > array[i]) minNum = array[i];
    }
    Console.WriteLine($"Максимальный эелемент = {maxNum} ");
    Console.WriteLine($"Минимальный элемент = {minNum}");
    double dif = maxNum - minNum;
    return dif;
}

Console.WriteLine($"Разница между максимальным и минимальным элементом = {GetDifference(array)}");

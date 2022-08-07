/* Задача 37 (не обязательная): Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве. */

int[] GetArray(int lengthArr)
{
int[] array = new int[lengthArr];
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(-100, 101);
}
return (array);
}

Console.Write("[ ");
int[] array = GetArray(10);
foreach (int i in array)
{
Console.Write($" {i} ");
}
Console.Write("]");

Console.WriteLine();

void GetProduct(int [] localArray)
{
Console.Write("Произведение пар чисел равно: ");
for (int i = 0; i < localArray.Length / 2; i++)
{
int prod = localArray[i] * localArray[localArray.Length - i - 1];

Console.Write($" {prod}");
}
}
GetProduct(array);

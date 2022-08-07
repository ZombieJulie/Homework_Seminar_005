/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.*/

int[] array = GetArray(5, -1000, 1000);
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
sum += i % 2 == 1 ? i : 0;
}
Console.Write("]");
Console.WriteLine();
Console.WriteLine($"Сумма нечетных чисел в массиве = {sum}");

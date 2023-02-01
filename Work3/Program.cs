// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] number = GetRandomArray(8);
PrintArray(number);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < number.Length; i++)
{
    if (number[i] > max)
    {
        max = number[i];
    }
    if (number[i] < min)
    {
        min = number[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

int[] GetRandomArray(int length)
{
    int[] result = new int[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-20, 21);
    }
    return result;
}

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}
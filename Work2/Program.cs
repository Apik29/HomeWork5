// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] number = GetRandomArray(8);
PrintArray(number);
int sum = 0;

for (int i = 0; i < number.Length; i += 2)
    sum = sum + number[i + 1];

Console.WriteLine($"сумма элементов, стоящих на нечётных позициях = {sum}");

int[] GetRandomArray(int length)
{
    int[] result = new int[length];

    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(1, 21);
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
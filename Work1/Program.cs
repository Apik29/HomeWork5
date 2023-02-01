// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] number = GetRandomArray(8);
PrintArray(number);
int count = 0;

for (int i = 0; i < number.Length; i++)
if (number[i] % 2 == 0)
count++;

Console.WriteLine($"{number.Length} чисел, {count} из них чётные");

int[] GetRandomArray(int length)
{
int[] result = new int[length];

for (int i = 0; i < length; i++)
{
result[i] = new Random().Next(100, 1000);
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
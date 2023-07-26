// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] arr)
{
    int len = arr.Length;
    int i = 0;
    while (i<len) {
        arr[i] = new Random().Next(100,1000);
        i++;
    }
}

void PrintArray(int[] arr)
{
    foreach (int element in arr) {
        Console.WriteLine(element);
    }
}

int CalcEvenCount(int[] arr)
{
    int count = 0;

    foreach (int element in arr) {
        if (element % 2 == 0) {
            count++;
        }
    }

    return count;
}

Console.Write("Задайте величину массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

FillArray(array);
PrintArray(array);

int countEvenElements = CalcEvenCount(array);
Console.WriteLine("Количество четных элементов: " + countEvenElements);
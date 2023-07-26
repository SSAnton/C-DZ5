// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = new Random().Next(-99,100);
    }
}

void PrintArray(int[] arr)
{
    foreach (int element in arr) {
        Console.WriteLine(element);
    }
}

int CalcSumOnOddPosition(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++) {
        if (i % 2 == 0) {
            sum += arr[i];
        }
    }

    return sum;
}

Console.Write("Задайте величину массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

FillArray(array);
PrintArray(array);

int sum = CalcSumOnOddPosition(array);
Console.WriteLine("Cумма элементов, стоящих на нечётных позициях: " + sum);
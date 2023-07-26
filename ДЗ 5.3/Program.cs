// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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

int FindMin(int[] arr)
{
    int min = arr[0];

    for (int i = 1; i < arr.Length; i++) {
        if (arr[i] < min) {
            min = arr[i];
        }
    }

    return min;
}

int FindMax(int[] arr)
{
    int max = arr[0];

    for (int i = 1; i < arr.Length; i++) {
        if (arr[i] > max) {
            max = arr[i];
        }
    }

    return max;
}

Console.Write("Задайте величину массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

FillArray(array);
PrintArray(array);

int min = FindMin(array);
int max = FindMax(array);
int diff = max - min;
Console.WriteLine("Разница между максимальным и минимальным элементами = " + diff);

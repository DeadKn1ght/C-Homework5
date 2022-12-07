// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

void FillArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(-99, 100);
    }
}

int notEven(int[] arr)
{
    int notEvenSumm = 0;
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        if ((i % 2) != 0) notEvenSumm += arr[i];
    }
    return notEvenSumm;
}

int[] array = new int[6];
FillArray(array);
System.Console.WriteLine('[' + string.Join(";", array) + ']');
int summNotEven = notEven(array);
System.Console.WriteLine("Summ of all not even elements of array is : " + summNotEven);
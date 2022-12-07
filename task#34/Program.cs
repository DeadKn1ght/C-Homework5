// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();

void FillArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}

int Division(int[] arr)
{
    int evenCount = 0;
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        if((arr[i] % 2) == 0)  evenCount++;
    }
    return evenCount;
}

int[] array = new int[4];
FillArray(array);
System.Console.WriteLine('[' + string.Join(";", array) + ']');
int evenNumbers = Division(array);
System.Console.WriteLine("Array has even numbers equal : " + evenNumbers);

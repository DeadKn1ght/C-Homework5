// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();

void FillArray(double[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().NextDouble()*100;
    }
}

double Difference(double[] arr)
{
    double diffMaxMin = 0;
    int length = arr.Length;
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < length; i++)
    {
        if (max < arr[i]) max = arr[i];
        if (min > arr[i]) min = arr[i];
    }
    System.Console.WriteLine("Max element of array is : " +max);
    System.Console.WriteLine("Min element of array is : " +min);
    diffMaxMin = max - min;
    return diffMaxMin;
}

double[] array = new double[6];
FillArray(array);
System.Console.WriteLine('[' + string.Join(";", array) + ']');
double differenceMaxMin = Difference(array);
System.Console.WriteLine("Difference between Max and Min elements of array is : " + differenceMaxMin);
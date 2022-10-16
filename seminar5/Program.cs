
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
    
    Console.WriteLine();
}

//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int ShowEvenElementsNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
            count++;
    }
    return count;
}

Console.Write("Input a numbers of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Minimal number of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Maximal number of elements: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] threeDigitArray = CreateRandomArray(size, min, max);
ShowArray(threeDigitArray);
int result = ShowEvenElementsNumbers(threeDigitArray);
Console.WriteLine($"In your array {result} even elements.");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
int SumElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
        sum += array[i];
    return sum;
}

Console.Write("Input a numbers of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Minimal number of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Maximal number of elements: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] randomArray = CreateRandomArray(size, min, max);
ShowArray(randomArray);
int result = SumElements(randomArray);
Console.WriteLine($"The sum of your array in uneven elements is {result}.");
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
double[] CreateDoubleArray(int size)
{
    double[] array = new double [size];
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine("Write element of array: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    Console.WriteLine("");
    return array;
}

void ShowDoubleArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
    
    Console.WriteLine();
}

double FindMinMax(double[] array)
{
    double max = array[0];
    double min = array[0];
    double result = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] > max) max = array[i];

    for(int i = 0; i < array.Length; i++)
        if(array[i] < min) min = array[i];

    result = max - min;
    result = Math.Round(result, 2);
    return result;
}

Console.Write("Input a numbers of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] endArray = CreateDoubleArray(size);
ShowDoubleArray(endArray);
double differens = FindMinMax(endArray);

Console.WriteLine($"In your array differens max and mun is {differens}.");
*/


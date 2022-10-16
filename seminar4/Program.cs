//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
double Degree(double a, int b)
{
    double result = a;
    for(int i = 1; i < b; i++)
        result = result * a;
    
    //double result;
    //result = Math.Pow(a, b);
    //result = Math.Round(result, 4);

    return result;
}

Console.Write("Input a number: ");
double number = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a natural degree: ");
int degree = Convert.ToInt32(Console.ReadLine());
double exponentation = Degree(number, degree);
Console.WriteLine($"The number {number} of degree {degree} is {exponentation}");
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int GetSum(int num)
{
    int sum = 0;
    int cut = 0;
    if(num < 0) num = num * (-1);
    while(num > 0)
    {
        cut = num % 10;
        sum = sum + cut;
        num = num / 10;
    }
    return sum;
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = GetSum(number);
Console.WriteLine($"The sum of number {number} is {sum}");
*/

//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*

int[] CreateArray(int size, int minValue, int maxValue)
{
    int[] array = new int [size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

int[] CreateUserArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine("Write a element of your array: "); 
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array [i] + " ");
    
    Console.WriteLine();
}

Console.Write("Input a numbers of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
//Console.Write("Minimal number of elements: ");
//int min = Convert.ToInt32(Console.ReadLine());
//Console.Write("Maximal number of elements: ");
//int max = Convert.ToInt32(Console.ReadLine());

int[] endArray = CreateUserArray(size);
ShowArray(endArray);
*/
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int PositiveNumbers()
{
    int count = 0;
    Console.Write("Enter the number of elements: ");
    int size = Convert.ToInt32(Console.ReadLine());
    for(int i = 0; i < size; i++)
    {
        Console.WriteLine("Input the number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if(number > 0)
            count++;
    } 
    return count;
}

int result = PositiveNumbers();
Console.Write($"You entered {result} positive numbers");
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
void IntersectionPoint()
{
    double x = 0;
    double y = 0;

    Console.Write("Enter a point b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter a point k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter a point b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter a point k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());

    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;

    x = Math.Round(x, 2);
    y = Math.Round(y, 2);

    Console.WriteLine($"Intersection point x is {x}");
    Console.WriteLine($"Intersection point y is {y}");
}

IntersectionPoint();
*/
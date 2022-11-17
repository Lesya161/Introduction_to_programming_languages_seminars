﻿

//Задача 64++: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void ShowNumbers(int n)
{
    Console.Write(n + " ");
    if(n > 1) ShowNumbers(n - 1);
}

Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowNumbers(number);

/*
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int SumNumbers(int m, int n)
{
    if (m > n) return n = n + SumNumbers(n + 1, m);
    if (m < n) return n = n + SumNumbers(n - 1, m);
    else
        return n;
}

Console.WriteLine("Input a number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = SumNumbers(number1, number2);
Console.WriteLine(result);


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman (int n, int m)
{
if (n == 0) return m + 1;
else
    {
        if ((n != 0) && (m == 0)) return Akkerman (n - 1, 1);
        else return Akkerman (n - 1, Akkerman (n, m - 1));
     }
}

Console.WriteLine("Input a number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = Akkerman(number1, number2);
Console.WriteLine(result);
*/
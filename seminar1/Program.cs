﻿// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int max = n1;
if(n1 > n2)
{
    max = n1;
}
else
{
    max = n2;
}

int min = n1;
if(n1 > n2)
{
    min = n2;
}
else
{
    min = n1;
}
Console.WriteLine($"max = {max} and min = {min}");
*/

// Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a fird number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1;
if(n1 > max)
{
    max = n1;
}
if(n2 > max)
{
    max = n2;
}
if(n3 > max)
{
    max = n3;
}
Console.Write("the maximum of these numbers is ");
Console.WriteLine(max);
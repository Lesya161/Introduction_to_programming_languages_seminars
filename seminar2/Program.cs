//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
/*
int SecondDigit(int num)
{
    //int result;
    // int second;
    if(num < 100 || num > 1000)
        return -1;
    else
    {
        //second = num / 10 % 10;
        //result = second;
        //return result;
        num = num / 10 % 10;
        return num;
    }
}

Console.WriteLine("Input a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigitNumber = SecondDigit(number);
Console.WriteLine($"second digit of {number} is {secondDigitNumber}");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int FirdDigit(int num)
{
    int result;
    if(num < 100)
        return -1;
    else
    {
        while(num >= 1000)
            num = num / 10;
            result = num % 10;
	    return result;
    }
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int firdDigitNumber = FirdDigit(number);
Console.WriteLine($"fird digit of {number} is {firdDigitNumber}");
*/

//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*void ShowNumbers(int num)
{
    int count = 1;
    while(count <= num)
    {
        double n = Math.Pow(count, 3);
        Console.Write(n + " ");
        count++;
    }
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowNumbers(number);
*/

//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double FindDistance(double xa, double xb, double ya, double yb, double za, double zb)
{
    double num = 0;
    num = Math.Pow((xa - xb), 2) + Math.Pow((ya - yb), 2) + Math.Pow((za - zb), 2);
    num = Math.Sqrt(num);
    num = Math.Round(num, 2);
    return num;
}

Console.Write("enter the coordinate х: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("enter the coordinate x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("enter the coordinate y: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("enter the coordinate y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("enter the coordinate z: ");
double z = Convert.ToDouble(Console.ReadLine());
Console.Write("enter the coordinate z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

double findDistans = FindDistance(x, x1, y, y1, z, z1);
Console.Write(findDistans);
*/

//Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
bool CheckPalindrome(int num)
{
    int first;
    int second;
    int forth;
    int fifth;

    if(num < 10000 || num >= 100000)
        return false;
    else
    {
        first = num / 10000;
        second = num / 1000 % 10;
        forth = num / 10 % 10;
        fifth = num % 10;

        if(first == fifth && second == forth)
            return true;
        else
            return false;
    }
}

Console.Write("Input a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your number {number} is palindrome? {CheckPalindrome(number)}");
*/


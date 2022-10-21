//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

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
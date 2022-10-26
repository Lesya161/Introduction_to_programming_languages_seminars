

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandomDouble2dArray() 
{
  Console.Write("Input a number of rows: ");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a number of columns: ");
  int columns = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a min possible value: ");
  int minVal = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a max possible value: ");
  int maxVal = Convert.ToInt32(Console.ReadLine());
  double number = 0;
  int integer = 0;

  double[,] array = new double[rows, columns];

  for(int i = 0; i < rows; i++) 
    for (int j = 0; j < columns; j++)
    {
        integer = new Random().Next(minVal,maxVal + 1);
        number = new Random().NextDouble();
        array[i,j] = integer + number;
        array[i,j] = Math.Round(array[i,j],2);
    }
  return array;
}
void Show2dDoubleArray(double[,] array) 
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i,j] + " ");
    Console.WriteLine();
  }
}

double [,] oneArray = CreateRandomDouble2dArray();
Show2dDoubleArray(oneArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


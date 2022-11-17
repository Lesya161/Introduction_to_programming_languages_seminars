
int[,] CreateRandom2dArray() 
{
  Console.Write("Input a number of rows: ");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a number of columns: ");
  int columns = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a min possible value: ");
  int minVal = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a max possible value: ");
  int maxVal = Convert.ToInt32(Console.ReadLine());

  int[,] array = new int[rows, columns];

  for(int i = 0; i < rows; i++) 
    for (int j = 0; j < columns; j++)
        array[i,j] = new Random().Next(minVal, maxVal + 1);
  return array;
}
void Show2dArray(int[,] array)  
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
      Console.Write(array[i,j] + " ");
    Console.WriteLine();
  }
}


/*
//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void SortedArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
      for (int a = j + 1; a < array.GetLength(1); a++)
        if (array[i, j] < array[i, a])
        {
          int temp = 0;
          temp = array[i, a];
          array[i, a] = array[i, j];
          array[i, j] = temp;
        }
  }

int[,] oneArray = CreateRandom2dArray();
Show2dArray(oneArray);
SortedArray(oneArray);
Console.WriteLine();
Show2dArray(oneArray);
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
void MinimumRow(int[,] array)
{
  if (array.GetLength(0) != array.GetLength(1))
  {
    int[] rowSumArray = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
      int sum = 0;
      for (int j = 0; j < array.GetLength(1); j++)
        sum = sum + array[i, j];
      rowSumArray[i] = sum;
    }

    int minSumRow = rowSumArray[0];
    int iMinSumRow = 0;

    for (int i = 1; i < rowSumArray.Length; i++)
      if (minSumRow > rowSumArray[i])
      {
        minSumRow = rowSumArray[i];
        iMinSumRow = i;
      }

     Console.WriteLine($"The row with the smallest sum of elements is {iMinSumRow + 1}");
  }

  else
    Console.WriteLine("Square array");
}

int [,] twoArray = CreateRandom2dArray();
Show2dArray(twoArray);
Console.WriteLine();
MinimumRow(twoArray);

*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int [,] ArrayProduct (int [,] oneArray, int[,] twoArray)
{
    int[,] productArray = new int[oneArray.GetLength(0), twoArray.GetLength(1)];
    if(oneArray.GetLength(1) == twoArray.GetLength(0))

        for (int i = 0; i < productArray.GetLength(0); i++)
            for (int j = 0; j < productArray.GetLength(1); j++)
                for (int a = 0; a < oneArray.GetLength(1); a++)
                    productArray[i,j] = productArray[i,j] + oneArray[i,a] * twoArray[a,j];
    return productArray;
}     

int [,] array1 = CreateRandom2dArray();
int [,] array2 = CreateRandom2dArray();
Show2dArray(array1);
Console.WriteLine();
Show2dArray(array2);
Console.WriteLine();
int [,] endArray = ArrayProduct(array1, array2);
Show2dArray(endArray);
*/

//Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[, ,] CreateRandom3dArray() 
{
  Console.Write("Input a number of rows: ");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a number of columns: ");
  int columns = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a number of width: ");
  int width = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a min possible value: ");
  int minVal = Convert.ToInt32(Console.ReadLine());
  Console.Write("Input a max possible value: ");
  int maxVal = Convert.ToInt32(Console.ReadLine());

  int[, ,] array = new int[rows, columns, width];

  for(int i = 0; i < rows; i++) 
    for (int j = 0; j < columns; j++)
      for (int k = 0; k < width; k++)
        array[i,j,k] = new Random().Next(minVal, maxVal+1);
  return array;
}

void Show3dArray(int[, ,] array)  
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
          Console.Write($"{array[i,j,k]} ({i},{j},{k}) ");
    }
    Console.WriteLine();
  }
}
int[, ,] array3d = CreateRandom3dArray();
Show3dArray(array3d);
*/
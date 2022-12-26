// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.WriteLine($"\nВведите данные массива и диапазон значений:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] arr = new int[m, n];
Fill2DArray(arr);
Print2DArray(arr);

Console.WriteLine($"\nОтсортированный массив: ");
OrderArrayLines(arr);
Print2DArray(arr);

// Сортируем элементы
void OrderArrayLines(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = 0; k < arr.GetLength(1) - 1; k++)
      {
        if (arr[i, k] < arr[i, k + 1])
        {
          int temp = arr[i, k + 1];
          arr[i, k + 1] = arr[i, k];
          arr[i, k] = temp;
        }
      }
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
// Задаем двумерный массив
void Fill2DArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = new Random().Next(range);
    }
  }
}
// Печатаем результат
void Print2DArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
  }
}

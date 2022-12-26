// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine($"\nВведите данные массива и диапазон  значений:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] arr = new int[m, n];
Fill2DArray(arr);
Print2DArray(arr);

int minSumRow = 0;
int sumRow =  MinRow(arr, 0);
for (int i = 1; i < arr.GetLength(0); i++)
{
  int tempSumRow =  MinRow(arr, i);
  if (sumRow > tempSumRow)
  {
    sumRow = tempSumRow;
    minSumRow = i;
  }
}

Console.WriteLine($"\n{minSumRow+1} - строкa с наименьшей суммой ({sumRow}) элементов ");

// Вычисляем строку с наименьшей суммой элементов
int MinRow(int[,] arr, int i)
{
  int sumRow = arr[i,0];
  for (int j = 1; j < arr.GetLength(1); j++)
  {
    sumRow += arr[i,j];
  }
  return sumRow;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
// Задаем массив
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
void Print2DArray (int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write(arr[i,j] + " ");
    }
    Console.WriteLine();
  }
}

// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц
// ("Предложим ввести матрицу, которая отвечает условию задачи, 
// т.е. количество столбцов первой равно количеству строк второй");
Console.WriteLine($"\nВведите размеры матриц и диапазон значений:");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон чисел: от 1 до ");

int[,] firstMartrix = new int[m, n];
Fill2DArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
Print2DArray(firstMartrix);

int[,] secomdMartrix = new int[n, p];
Fill2DArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
Print2DArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
Print2DArray(resultMatrix);

// Метод произведения двух матриц
void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
// Заполняем матрицы
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
// Печатаем результаты
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

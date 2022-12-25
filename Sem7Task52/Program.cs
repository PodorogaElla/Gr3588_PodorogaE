// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.
// Запрос данных пользователяю, принимает строку заголовок.
Console.WriteLine ("Введите число строк: ");
int m = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите число столбцов: ");
int n = Convert.ToInt32 (Console.ReadLine());
int[,] massive = new int [m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        massive[i,j] = new Random().Next (-10, 10);
        Console.Write (massive[i,j]+" ");
    }
    Console.WriteLine();
}
// Считает среднее арифметическое по столбцам.
int result = 0;

for (int j = 0; j < n; j++)
{
    result = Average(j);
    Console.WriteLine(result);
}

int Average(int column)
{
    int average = 0;
    int x = 0;
    for (int i = 0; i < m; i++)
    {
      average += massive[i, column];
    }
       x = average / m;
    {
    return x;
    }
}
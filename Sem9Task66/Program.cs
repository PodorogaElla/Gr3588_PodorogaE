// Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

int m = ReadData("Введите число M: ");
int n = ReadData("Введите число N: ");
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSumm(m, n, temp=0);

// Метод рекурсионного суммирования с выводом на печать 
void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов= {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int m = int.Parse(Console.ReadLine() ?? "0");
    return m;
    
 }

// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Считываем данные ввода, с преобразованием в массив int
Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int N = 0;
int result = CountPosNum ( N);
Console.WriteLine($"Кол-во элементов > 0: {result}");

// Метод подсчета положитительных чисел
int CountPosNum (int N)
{
    int res = 0;
    while (N > 0)
    {
        if (N > 0)
            res ++;
            N = N - 1;
    }
        return res;
}
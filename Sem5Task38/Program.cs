// Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
double[] array = GenArray(5,100,999);
PrintArray(array);
double maxValue =  double.MinValue; 
double minValue =  double.MaxValue; 
double result = MinMax(maxValue-minValue);
Console.WriteLine();
PrintData("Разница между макс и мин элементами массива ", result);

// Заполняем массив
double[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    double[] outArray = new double[len];
    for (int i = 0; i < len; i++)
    {
        outArray[i] = new Random().Next(minValue, maxValue);
    }
    return outArray;
}

//Печатаем массив
void PrintArray(double[] arr) 
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

// Метод печати результата в консоль
void PrintData(string res, double value)
{
   Console.WriteLine(res);
}

// Метод вычисления min b max значений
void MinMax(double[] arr)
{
     for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxValue)
            maxValue = arr[i];       
        if (arr[i] < maxValue)
            minValue = arr[i];
    }
}
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
int[] array = GenArray(120,100,999);
PrintArray(array);
int result = SumOdd(array);
Console.WriteLine();
PrintData("Сумма чисел на нечетных позициях в массиве ", result);

// Заполняем массив
int[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] outArray = new int[len];
    for (int i = 0; i < len; i++)
    {
        outArray[i] = new Random().Next(minValue, maxValue);
    }
    return outArray;
}
// Печатаем результат
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

//Печатаем массив
void PrintArray(int[] arr) 
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}
// Метод вычисления суммы чисел на нечетных позициях 
int SumOdd(int[] array)
{
    int res = 0;
    int i = 1;
    while (i < array.Length)
    {
        res+= array [i];
        i = i + 2;
    }
return res;
}




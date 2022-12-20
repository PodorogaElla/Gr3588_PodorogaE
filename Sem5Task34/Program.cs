// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет
//  количество чётных чисел в массиве.
// * Отсортировать массив методом пузырька

int[] array = GenArray(120,100,999);
PrintArray(array);
int result = CountEven(array);
Console.WriteLine();
PrintData("Количество четных чисел в массиве ", result);

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
// Метод вычисления количества четных чисел
int CountEven(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2==0)
        {
            res++;
        }
    }
    return res;
}


//  Напишите программу, которая найдёт точку пересечения 
// двух прямых, заданных уравнениями y = k1 * x + b1, 
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Считываем данные,с преобразованием в вещественные числа
Console.WriteLine("Введите координату b1: ");
int b1 = (int)Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату k1: ");
int k1 = (int)Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату b2: ");
int b2 = (int)Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату k2: ");
int k2 = (int)Convert.ToDouble(Console.ReadLine());
CrossPoint(k1,b1,k2,b2);

//Метод вычисления точки пересечения двух прямых
void CrossPoint(double k1, double b1, double k2, double b2)
{
double x = (b1-b2)/(k2-k1);
double y = (k2*b1-k1*b2)/(k2-k1);
if(k1==k2) Console.Write("Заданные прямые не пересекаются!");
else
Console.Write($"Точка пересечения заданных прямых: ({x}; {y})");
}



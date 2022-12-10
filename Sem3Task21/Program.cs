int coordX1 = ReadData("Введите координату X1: ");
int coordY1 = ReadData("Введите координату Y1: ");
int coordZ1 = ReadData("Введите координату Z1: ");
int coordX2 = ReadData("Введите координату X2: ");
int coordY2 = ReadData("Введите координату Y2: ");
int coordZ2 = ReadData("Введите координату Z2: ");
double result = CalculateLength(coordX1, coordY1, coordZ1, coordX2, coordY2, coordZ2);

PrintData("Расстояние между точками: ", result);


// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод находит расстояние между точками на плоскости
double CalculateLength(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double distance = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
    return distance;
} 

//Метод выводит данные пользователю
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

// // Метод читает данные от пользователя
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

// int coordX1 = ReadData("Введите координату X1: ");
// int coordY1 = ReadData("Введите координату Y1: ");
// int coordZ1 = ReadData("Введите координату Z1: ");
// int coordX2 = ReadData("Введите координату X2: ");
// int coordY2 = ReadData("Введите координату Y2: ");
// int coordZ2 = ReadData("Введите координату Z2: ");

// //Метод находит расстояние между точками на плоскости
// double CalculateLength(double x1, double x2, double y1, double y2, double z1, double z2)
// {
//     double res = 0;
//     res = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
//     return res;
// }

// //Метод выводит данные пользователю
// void PrintData(string msg, double result)
// {
//     Console.WriteLine(msg + result);
// }

// PrintData("Расстояние между точками ", CalculateLength(coordX1, coordY1, coordZ1, coordX2, coordY2, coordZ2));

// Этот вариант считает не верно!
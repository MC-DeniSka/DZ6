// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void CrossDot(double k1,double b1,double k2,double b2)
{
    if(b1 == b2  && k1 == k2)
    {
        System.Console.WriteLine("Прямые совпадают, количество точек пересечения - бесконечность");
    }
    else if(k1 == k2)
    {
        System.Console.WriteLine("Прямые параллельны, точек пересечения не существует");
    }
    else
    {
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    System.Console.WriteLine("Точка пересечения прямых ("+x+" ; "+y+")");
    }
    
}


System.Console.WriteLine(" Введите значение переменной b1");
double b1 = double.Parse(Console.ReadLine()!);
System.Console.WriteLine(" Введите значение переменной k1");
double k1 = double.Parse(Console.ReadLine()!);
System.Console.WriteLine(" Введите значение переменной b2");
double b2 = double.Parse(Console.ReadLine()!);
System.Console.WriteLine(" Введите значение переменной k2");
double k2 = double.Parse(Console.ReadLine()!);

CrossDot(k1,b1,k2,b2);
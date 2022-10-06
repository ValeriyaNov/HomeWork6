// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using static System.Console;
Clear();
Write("Введите значения коэффициентов: k1, b1, k2, b2  через пробел ");
string[] parameters=ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

IntersectionPoint(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));

void IntersectionPoint(double a1, double c1, double a2, double c2)
{
    if(a2==a1) 
        WriteLine("данные прямые параллельны");
    else
    {
        double x=((c2-c1)/(a1-a2));
        double y=a1*x+c1;
        WriteLine($"Точка пересечения прямых A({Math.Round(x,2)}; {Math.Round(y,2)})");
    }
}


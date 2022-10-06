// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
//чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
using static System.Console;
Clear();
WriteLine("Введите несколько чисел через пробел: ");
string[] parameters=ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int number=NumPositive(parameters);
WriteLine(number);




int NumPositive(string[] Array)
{
    int count=0;
    for (int i=0; i<Array.Length; i++)
    {
        if (int.Parse(Array[i])>0) count++; 
    }
    return count;
}

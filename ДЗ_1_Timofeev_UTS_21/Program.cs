using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.Write(" Перевод числа «а» из радиан в градусы.\n\n Диапазон числа «а»:\n  (0<а<2*pi).\n\n Число «pi»:\n   3,14.\n\n");
        //Условие 

        Console.Write(" Введите параметр «а»: ");
        double a = double.Parse(Console.ReadLine());
        //Ввод пользователем число альфа

        if (a is > 0 and < (2 * 3.14))
        {
            double X = (a * 180) / 3.14;
            Console.WriteLine("\n Ответ: " + Math.Round(X, 3));
        }
        else
        {
            Console.WriteLine("\n ВНИМАНИЕ! Число превышает доопустимый диапозон.");
        }
    }   //Перевод числа в градусы с соблюдением диапазона и плавающей запятой
}
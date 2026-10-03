using System;


static void Main()
{
    Console.Write("Введите первое число: ");
    double number1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите второе число: ");
    double number2 = Convert.ToDouble(Console.ReadLine());

    double sum = number1 + number2;

    Console.WriteLine($"***Результаты операций: {sum}***");
}

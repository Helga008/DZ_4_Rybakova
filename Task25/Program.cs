// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.

int User(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}


double AexponentiationB(double num1, double num2)
{
    double result = 1;
    for (double i = 1; i <= num2; i++) 
    {
        result = result * num1;
    }
    return result;
}

double number_1 = User("Введите первое число ");
double number_2 = User("Введите второе число ");

double stepen = AexponentiationB(number_1, number_2);
Console.WriteLine($"Число {number_1} в степени числа {number_2} равно {stepen}");

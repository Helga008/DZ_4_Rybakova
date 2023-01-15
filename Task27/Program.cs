// Напишите программу, которая принимает на вход число и выдает сумму цифр в этом числе

int User(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int SumDigitInNumb(int number)
{ 
    int sum = 0;
    while (number > 0)
    {     
        int num = number % 10;
        sum = sum + num;
        number = number / 10;
    }
    return sum;
}

int number1 = User("Введите число: ");
int Sum = SumDigitInNumb(number1); 
Console.WriteLine(Sum);

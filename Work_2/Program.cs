//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int Prompt(string message) 
    System.Console.Write (message);
    return int.Parse(Console.ReadLine());
}
int Sum(int number)
{
    int sum = 0;
    while (Math.Abs(number) > 0)
    {
        sum +=  Math.Abs(number) %10;
        number = Math.Abs(number) / 10;
    }
    return sum;
}
int number = Prompt("Введите число ->> ");
int result = Sum(number);
System.Console.WriteLine($"Сумма цифр числа '{number}' равна {result}.");
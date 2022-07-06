//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Prompt(string number_A) 
{
    System.Console.Write (number_A);

    return int.Parse(Console.ReadLine());
}

double SumDigits_2(double numberA,double numberB)
{
    double sum = Math.Pow(numberA,numberB);
    return sum;
}

int A = Prompt("Введите число A-> ");
int B = Prompt("Введите число B-> ");
double result = SumDigits_2(A,B);
System.Console.WriteLine($"Число {A} в степени {B} = {result}");

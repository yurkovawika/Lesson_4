//Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] myArray = {1,4,2,7,4,9,2,5};
void PrintArray(int [] array)
{
    Console.Write("[ ");
    Console.Write($"{array[0]}");
    int count = array.Length;
    for(int i = 1; i < count;i++)
    {
        Console.Write(", " + array[i]);
    }
    Console.WriteLine(" ]");
}

PrintArray(myArray);
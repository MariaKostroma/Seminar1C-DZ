// Задача23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
//кубов чисел от 1 до N.

int num = SetNumber("N");

int SetNumber(string str)
{
    System.Console.WriteLine($"Введите число {str}");
    int num = int.Parse(Console.ReadLine());
    return num;
}

    for (int i = 1; i<= num; i++)
    {
        Console.Write($"{i*i*i}, ");
    }
    Console.WriteLine();


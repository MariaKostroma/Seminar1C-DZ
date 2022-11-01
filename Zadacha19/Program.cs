// Задача19. Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (num<10000)
{
    Console.WriteLine("Вы ввели не пятизначное число");
}
else
{
    int firstnum = num / 10000;
    int fifthnum = num % 10;
    int secondnum = (num / 1000) % 10;
    int forthnum = (num / 10) % 10;
    if (firstnum == fifthnum && secondnum == forthnum)
    {
      Console.WriteLine("Число является палиндромом");  
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
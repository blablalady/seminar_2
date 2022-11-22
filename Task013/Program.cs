/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.Write ("Введите число: ");
int num = Convert.ToInt32 (Console.ReadLine ());
int result = 0;

if (num >= 100 && num <= 999)
{
    result = num % 10;
    Console.WriteLine ("Третья цифра " + result);
}
else if (num < 100)
{
    Console.WriteLine ("Третьей цифры нет");
}
else if (num > 999)
{
    while (num > 999)
    {
        num = num /10;
        if (num >= 100 && num <= 999)
        {
        result = num % 10;
        Console.WriteLine ("Третья цифра " + result);
        }
    }
    
}
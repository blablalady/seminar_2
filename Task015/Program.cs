/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Write ("Введите цифру дня недели: ");
int dayNum = Convert.ToInt32 (Console.ReadLine ());

if (dayNum <= 5 && dayNum >= 1)
{
    Console.WriteLine ("Сегодня идем на работу!");
}
else if (dayNum >= 6 && dayNum <= 7)
{
    Console.WriteLine ("Ура, сегодня выходной!");
}
else
{
    Console.WriteLine ("Такого дня недели не существует");
}

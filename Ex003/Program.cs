﻿ //Напишите программу, которая принимает на вход цифру, 
 //обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine ("Введите число: ");
 int day = int.Parse (Console.ReadLine());

if (day>7 || day <1)
{
    Console.WriteLine ("Число " + day + " не является днем недели");
}
 else if (day>5)
{
 Console.WriteLine ("Число " + day + " является выходным днем недели");
}
else 
{
 Console.WriteLine ("Число " + day + "  является рабочим днем недели");
}
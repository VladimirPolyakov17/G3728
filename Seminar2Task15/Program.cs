﻿//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

//Считываем с консоли число
int day = int.Parse(Console.ReadLine() ?? "0");
//Вводим ограничение на количество дней
if (day > 7 && day <1)
{
  Console.WriteLine("Не день недели");
}
else
{
  if (day >=6 && day <=7)
  {
    Console.WriteLine("Выходной день");
  }
  else
  {
    Console.WriteLine("Рабочий день");
  }
}
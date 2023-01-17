// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

//Вариант 2
System.Random numSintezator = new System.Random();
int num = numSintezator.Next(100, 1000);
int digit1 = num/100;
int digit2 = num%10;
Console.WriteLine(digit1*10+digit2);
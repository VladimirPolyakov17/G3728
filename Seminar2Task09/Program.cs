//Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа

//Вариант 1
System.Random numSintezator = new System.Random();

int rndNum = numSintezator.Next(10,100);
Console.WriteLine("Cлучайное число: " + rndNum);

int digit1 = rndNum/10;
int digit2 = rndNum%10;

if(digit1>digit2)
{
  Console.WriteLine("Цифра 1 болььше цифры 2: "+ digit1 +" "+digit2);
}
else
{
  Console.WriteLine("Цифра 2 больше 1: " +digit1 + " " + digit2);
}

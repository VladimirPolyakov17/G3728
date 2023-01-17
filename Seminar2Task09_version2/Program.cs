//Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа

//Вариант 2
System.Random numSintezator = new System.Random();
char[] digits = numSintezator.Next(10,100).ToString().ToCharArray();
Console.WriteLine(digits);
int digit1 = (int)digits[0]-48;
int digit2 = (int)digits[1]-48;
int resNum = digit1>digit2?digit1:digit2;
Console.WriteLine(resNum);

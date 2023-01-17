// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

//Вариант 1

System.Random random = new System.Random();

int randomNumber = random.Next(100,1000);

Console.WriteLine("число: " + randomNumber);

string value = randomNumber.ToString();

char[] numberArray = value.ToCharArray();

Console.WriteLine(numberArray[0] + "" + numberArray[2]);

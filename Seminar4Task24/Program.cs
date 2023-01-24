//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

//Метод читает данные от пользователя
int ReadData(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
// Выводим результат пользователю
void PrintData(string msg1, int msg2)
{
  Console.WriteLine(msg1);
  Console.WriteLine(msg2);
}

int SumSimple(int numA)
{
  int sumOfNum = 1;
  for(int i=2; i<=numA; i++)
  {
    sumOfNum+=i;
  }
  return sumOfNum;
}

int numberA = ReadData("Введите число А");

int res1 = SumSimple(numberA);

PrintData("Сумма чисел от 1 до А: ",res1);

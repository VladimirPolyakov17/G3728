//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//Вариант 2

int num1 = int.Parse(Console.ReadLine()??"0");

int res1 = num1%7;
int res2 = num1%23;
if((res1==0)&&(res2==0))
{
Console.WriteLine("Кратное ");
}

else
{
Console.WriteLine("Не кратно " + res1 + " " + res2);
}

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
//Вариант 1. Недоделанный.
// int num1 = int.Parse(Console.ReadLine()??"0")
// int num2 = int.Parse(Console.ReadLine()??"0")
// if(num1*num1==num2)
// {
//   Console.Write
// }
//Вариант 2. Верный.
Console.WriteLine("input yor nums: ");
// Вводим данные с консоли
int num1 = int.Parse(Console.ReadLine() ?? "0");// Ввод первого числа
int num2 = int.Parse(Console.ReadLine() ?? "0");// Ввод второго числа
//сравнение возведённого в квадрат числа с другим числом
if ((int)Math.Pow(num1, 2) == num2)
{
    Console.Write("да, число "+num2+" является степенью числа "+num1);//вывод согласия
}
else
{
    if ((int)Math.Pow(num2, 2) == num1)
    {
        Console.Write("да, число "+num1+" является степенью числа "+num2);//вывод согласия
    }
    else
    {
        Console.Write("Нет, числа "+num1+" и "+num2+" не являются чьей либо степенью");//вывод не согласия
    }
}

//void TestSQRT(int i, int j) - тест на квадратность. Нужно допилить.
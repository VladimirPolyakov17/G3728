//Задача №1
//Напишите программу, которая на вход принимаетдва числа и проверяет, является ли первое число квадратом второго.
//Например:
//a = 25; b = 5 -> да
//a = 2 b = 10 -> нет
//a = 9; b = -3 -> да
//a = -3 b = 9 -> нет

//Cчитываем данные с консоли 1 число
string? inputNum1 = Console.ReadLine();
//Cчитываем данные с консоли 2 число
string? inputNum2 = Console.ReadLine();

//Проверяем, чтобы данные были не пустыми
if(inputNum1!=null && inputNum2!=null )
{
    //парсим введенное число
    int number1 = int.Parse(inputNum1);
    //парсим введенное число
    int number2 = int.Parse(inputNum2);

    if(number1==number2*number2)
    {
      Console.WriteLine("Первое число квадрат второго!");
    }
    else
    {
      Console.WriteLine("Первое число не квадрат второго!");
    }
}
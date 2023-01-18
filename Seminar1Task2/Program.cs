//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

//Cчитываем данные с консоли 1 число
string? inputNum1 = Console.ReadLine();
//Cчитываем данные с консоли 2 число
string? inputNum2 = Console.ReadLine();
//Проверяем, чтобы данные были не пустыми
if(inputNum1!=null && inputNum2!=null )
{
    //Ввод переменной
    int max = 0; 
    //парсим введенное число
    int number1 = int.Parse(inputNum1);
    //парсим введенное число
    int number2 = int.Parse(inputNum2);
    //Сравниваем числа
    if (number1 > number2)
    {
      //Если верно, то переменная max имеет значение первого числа
      max = number1;
      //Вывод данных на консоль
      Console.WriteLine("max="+max);
    }
    else
    { //Если неверно, то переменная max имеет значение второго числа
      max = number2;
      //Вывод данных на консоль
      Console.WriteLine("max="+max);
    }
}  
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("input your nums: ");
//Cчитываем данные с консоли 1 число
string? inputNum1 = Console.ReadLine();
//Cчитываем данные с консоли 2 число
string? inputNum2 = Console.ReadLine();
//Cчитываем данные с консоли 3 число
string? inputNum3 = Console.ReadLine();

//Проверяем, чтобы данные не были пустыми
if(inputNum1!=null && inputNum2!=null && inputNum3!=null)

{
  //Парсим введенные числа
  int number1 = int.Parse(inputNum1);
  int number2 = int.Parse(inputNum2);
  int number3 = int.Parse(inputNum3);

  //Ввод переменной для нахождения максимального числа.
  int max = Math.Max(number1, Math.Max(number2, number3));
  
  //Вывод на консоль максимального числа
  Console.WriteLine("max=" +max);
}
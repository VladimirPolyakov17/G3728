//Задача №17
//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
int coordX = ReadDate("Введите координату X");
int coordY = ReadDate("Введите координату Y");
PrintQuterTest(coordX,coordY);

//Сверху решение, чтобы не было как ниже многоразовых повторений
// Console.WriteLine("Введите координату X");
// int coordx = int.Parse(Console.ReadLine()??"0");
// Console.WriteLine("Введите координату X");
// int coordx = int.Parse(Console.ReadLine()??"0");
// Console.WriteLine("Введите координату X");
// int coordx = int.Parse(Console.ReadLine()??"0");
// Console.WriteLine("Введите координату X");
// int coordx = int.Parse(Console.ReadLine()??"0");
// Console.WriteLine("Введите координату X");
// int coordx = int.Parse(Console.ReadLine()??"0");
// Console.WriteLine("Введите координату X");
// int coordx = int.Parse(Console.ReadLine()??"0");

//Метод читает данные от пользователя
int ReadDate(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");

}
// Метод определяет четверть по координатам точки
void PrintQuterTest(int X, int Y)
{
  if(coordX > 0 && coordY > 0) Console.WriteLine("Точка в четверти 1");
  if(coordX > 0 && coordY < 0) Console.WriteLine("Точка в четверти 2");
  if(coordX < 0 && coordY < 0) Console.WriteLine("Точка в четверти 3");
  if(coordX < 0 && coordY > 0) Console.WriteLine("Точка в четверти 4");
}
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// * Сделать метод загрузки точек

//Метод читает данные от пользователя
int ReadDate(string msg)
{
  Console.WriteLine(msg);
  return int.Parse(Console.ReadLine() ?? "0");
}
//Выводим результат пользователю
void PrintData(string msg, double res)
{
  Console.WriteLine(msg + res);
}
// Вычисляем расстояние между точками в 2D пространстве
double CalcLen(int x1, int x2, int y1, int y2, int z1, int z2)
{
  double res = 0;
  res = Math.Sqrt(Math.Pow(x1-x2,2)+ Math.Pow(y1 - y2, 2)+ Math.Pow(z1 - z2,2));
  return res;
}

//Вводим координаты точек
int coordX1 = ReadDate("Введите координату x1");
int coordX2 = ReadDate("Введите координату x2");
int coordY1 = ReadDate("Введите координату y1");
int coordY2 = ReadDate("Введите координату y2");
int coordZ1 = ReadDate("Введите координату z1");
int coordZ2 = ReadDate("Введите координату z2");

//Вычисляем длину
double len = CalcLen(coordX1, coordX2, coordY1,coordY2, coordZ1, coordZ2);

//Выдаем результат
PrintData("Расстояние между точками: ",len);


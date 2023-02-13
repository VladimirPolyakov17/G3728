// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//Метод печати трёхмерного цветного массива
void Print3DArrayColor(int[,,] matrix)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.ForegroundColor = col[matrix[i, j, k] % 15];
                Console.Write(matrix[i, j, k] + "(" + i + j + k + ")" + "     ".Substring(matrix[i, j, k].ToString().Length));
                Console.ResetColor();
            }
        Console.WriteLine();
        }
    }
}

//Генерация случайного числа из списка с последующим удалением его из списка
int GenNum(List<int> num)
{
    int index = new Random().Next(0, num.Count);
    int outNum = index;
    num.RemoveAt(index);
    return outNum;
}

//Заполняем трехмерный массив случайными неповторяющимися числами
int[,,] Fill3DArray(int countRow, int countColumn, int countList, List<int> num)
{
    int[,,] array3D = new int[countRow, countColumn, countList];
    for (int k = 0; k < countList; k++)
    {
        for (int i = 0; i < countRow; i++)
        {
            for (int j = 0; j < countColumn; j++)
            {
                array3D[i, j, k] = GenNum(num);
            }
        }
    }
    return array3D;
}

int row = ReadData("Введите количество строк "); // Пользователь вводит количество строк
int column = ReadData("Введите количество столбцов "); // Пользователь вводит количество столбцов
int list = ReadData("Введите количество листов "); // Пользователь вводит количество листов

//Заполняем список двухзначными числами
List<int> num = new List<int>();
for (int i = 0; i < 90; i++)
{
    num.Add(10 + i);
}

int[,,] arr3D = Fill3DArray(row, column, list, num); //Заполнение трехмерного массива  
Print3DArrayColor(arr3D); //Печать трехмерного цветного массива 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет. 
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// 17 -> такого числа в массиве нет 

//Метод считывает  данные от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метод генерации и заполнение двумерного массива
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);
        }
    }
    return array2D;
}

//Метод печатает цветной двумерный массив
void Print2DArrayColor(int[,] matrix)
{
    ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];
            Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

//Метод вывода данных
void PrintData(string msg, int[,] arr2D, int i, int j)
{
    if (i < arr2D.GetLength(0) && j < arr2D.GetLength(1))
    {
        Console.WriteLine(msg + arr2D[i, j]);
    }
    else
    {
        Console.WriteLine("Элемента с таким индексом в массиве нет");
    }
}

int row = ReadData("Введите количество строк "); //Ввод данных
int column = ReadData("Введите количество столбцов "); //Ввод данных
int[,] arr2D = Fill2DArray(row, column, 10, 99); //Заполнение массива
Print2DArrayColor(arr2D); //Печать массива
int i = ReadData("Введите номер строки элемента ");
int j = ReadData("Введите номер столбца элемента ");
PrintData("Значение заданногоэлемента: ", arr2D, i, j); //Вывод результата
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Генерируем двумерный массив, заполненный случайными числами
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

//Метод печати двумерного цветного массива
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
            Console.ForegroundColor = col[matrix[i, j] % 15];
            Console.Write(matrix[i, j] + "     ".Substring(matrix[i, j].ToString().Length));
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

//Метод сортировки строки по убыванию
void SortRow(int[] sortRow)
{
    for (int i = 0; i < sortRow.Length; i++)
        for (int j = 0; j < sortRow.Length - i - 1; j++)
        {
            if (sortRow[j] < sortRow[j + 1])
            {
                int temp = sortRow[j];
                sortRow[j] = sortRow[j + 1];
                sortRow[j + 1] = temp;
            }
        }
}

//Метод сортировки строк массива по убыванию
int[,] Sort2DArray(int[,] arr2D)
{
    int[] sortRow = new int[arr2D.GetLength(1)];
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
        sortRow[j] = arr2D[i, j];
        }
        SortRow(sortRow);
        for (int j = 0; j < arr2D.GetLength(1); j++)
        arr2D[i, j] = sortRow[j];    
    }   
    return arr2D;
}

int row = ReadData("Введите количество строк "); // Пользователь вводит количество строк
int column = ReadData("Введите количество столбцов "); // Пользователь вводит количество столбцов
int[,] arr2D = Fill2DArray(row, column, 0, 9); //Заполнение массива  
Print2DArrayColor(arr2D); //Печать двумерного цветного массива   
Console.WriteLine(); //Перенос на новую строку
Sort2DArray(arr2D); //Сортировка двумерного массива
Print2DArrayColor(arr2D); //Печать отсортированного двумерного цветного массива
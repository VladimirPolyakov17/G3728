// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

//Метод нахождения произведения двух матриц
int[,] MatrixMultiplication(int[,] arr1, int[,] arr2)
{
    int[,] arrMulti = new int[arr1.GetLength(0), arr2.GetLength(1)];

    for (int i = 0; i < arr1.GetLength(0); i++)
        for (int j = 0; j < arr2.GetLength(0); j++)
            for (int k = 0; k < arr2.GetLength(1); ++k)
                arrMulti[i, k] += arr1[i, j] * arr2[j, k];
    return arrMulti;
}

int row = ReadData("Введите количество строк "); // Пользователь вводит количество строк
int column = ReadData("Введите количество столбцов "); // Пользователь вводит количество столбцов
int[,] arr1 = Fill2DArray(row, column, 0, 9); //Заполнение массива  
Print2DArrayColor(arr1); //Печать двумерного цветного массива   
Console.WriteLine(); //Перенос на новую строку
int[,] arr2 = Fill2DArray(row, column, 0, 9); //Заполнение массива  
Print2DArrayColor(arr2); //Печать двумерного цветного массива   
Console.WriteLine(); //Перенос на новую строку
int[,] arrMulti = MatrixMultiplication(arr1, arr2); //Находим произведение двух матриц
Print2DArrayColor(arrMulti); //Печать произведения двух матриц 
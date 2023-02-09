// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. 
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. 

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

//Метод расчета среднего арифметического элементов в каждом столбце.
int[] CalkAvg(int[,] arr2D)
{   
    int [] avg = new int[arr2D.GetLength(1)];
    for (int j = 0; j < arr2D.GetLength(1); j++)
    {
        for (int i = 0; i < arr2D.GetLength(0); i++)
        {
            avg[j] += arr2D[i,j];
        }
    avg[j] = avg[j]/arr2D.GetLength(1);
    }
    return avg;
}

//Метод печати одномрного массива
void Print1DArr(int[] avg)
{
    for (int i = 0; i < avg.Length - 1; i++)
    {
        Console.Write(avg[i] + ", ");
    }
    Console.WriteLine(avg[avg.Length - 1]);
}

int row = ReadData("Введите количество строк "); //Ввод данных
int column = ReadData("Введите количество столбцов "); //Ввод данных
int[,] arr2D = Fill2DArray(row, column, 10, 99); //Заполнение массива
Print2DArrayColor(arr2D); //Печать двумерного массива
int[] avg = CalkAvg(arr2D); //Расчет среднего арифметического элементов в каждом столбце.
Print1DArr(avg); //Печать одномерного массива из средних арифметических элементов
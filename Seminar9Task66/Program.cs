// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(int sumMN)
{
    Console.WriteLine(sumMN);
}

//Метеод для нахождения суммы натуральных элементов в промежутке от M до N
int RecSumMN(int M, int N)
{
    if (M >= N)
    {
        return N;
    }
    else
    {
        return M + RecSumMN(M + 1, N);
    }
}
int M = ReadData("Введите число M: "); // Чтение данных из консоли
int N = ReadData("Введите число N: "); // Чтение данных из консоли
int sumMN = RecSumMN(M, N); //Расчет суммы с помощью рекурсии
PrintResult(sumMN); //Печать результата
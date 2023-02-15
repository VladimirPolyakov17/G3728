// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать результата
void PrintResult(int ackermannFunction)
{
    Console.WriteLine(ackermannFunction);
}

///Метод вычисления функции Аккермана:
int AckermannFunction(int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return AckermannFunction(M - 1, 1);
    if (M > 0 && N > 0) return AckermannFunction(M - 1, AckermannFunction(M, N - 1));
    return AckermannFunction(M, N);
}

int M = ReadData("Введите число M: "); // Чтение данных из консоли
int N = ReadData("Введите число N: "); // Чтение данных из консоли
int ackermannFunction = AckermannFunction(M, N); //Вычисление функции Аккермана
PrintResult(ackermannFunction); //Печать функции Аккермана
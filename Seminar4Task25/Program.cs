// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Вывод числа с помощью метода ReadData
int num = ReadData("Введите число: ");

//Вывод степени с помощью метода ReadData
int pow = ReadData("Введите степень: ");

//Возведение числа в n-ую степень с помощью метода ExpNum
int expNum = ExpNum(num, pow);

// Метод возведения числа в n-ую степень
int ExpNum(int num, int pow)
{
    int expNum = num;
    for (int i = 1; i < pow; i++)
    {
        expNum = expNum*num;
    }
    return expNum;
}

// Метод вывода данных
void PrintData(int expNum)
{
    Console.WriteLine(expNum);
}

//Вывод расчета  
PrintData(expNum);
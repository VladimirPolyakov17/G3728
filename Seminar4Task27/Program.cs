// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Вывод числа с помощью метода ReadData
int num = ReadData("Введите число: ");

//Расчет суммы с помощью метода SumSym
int res = SumSym(num);

// Метод вывода данных
void PrintData(int res)
{
    Console.WriteLine(res);
}

//Метод считает сумму цифр в числе
int SumSym (int num)
{
    int res =0;
    while(num > 0)
    {
        res= num%10+res;
        num= num/10;
    }
    return res;
}

//Вывод расчета 
PrintData(res);
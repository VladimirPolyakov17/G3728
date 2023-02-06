// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// 0, 7, 8, -2, -2 -> 2 
// -1, -7, 567, 89, 223-> 3 
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.


//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод, выводящий на печать данные пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}

//Метод считает количество положительных чисел введенных пользователем
int CountPosNum(int num)
{
    int res = 0;
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите число {i + 1}: ");
        int digit = int.Parse(Console.ReadLine() ?? "0");
        if (digit > 0) res++;
    }
    return res;
}

int num = ReadData("Введите количество чисел: "); //Ввод количества чисел
int res = CountPosNum(num); //Расчет количества чисел > 0
PrintData("Количество чисел > 0 равно: " + res);// Вывод результата
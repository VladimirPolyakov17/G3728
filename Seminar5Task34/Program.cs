// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

//Метод чтения данных из консоли
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Метод генерации массива трёхзначными числами
int[] GenArr(int num)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

//Метод печатает одномерный массив
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

//Метод считает количество четных чисел
int CountEven(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) res++;
    }
    return res;
}

//Метод вывода результата
void PrintData(string res, int count)
{
    Console.WriteLine(res + count);
}

int num = ReadData("Введите длину массива");//Ввод данных
int[] array = GenArr(num);//Генерация массива
PrintArray(array);//Печать массива
int count = CountEven(array);//Расчет количества четных чисел
Console.WriteLine();//Перевод на новую строку печати
PrintData("Количество четных чисел равно: ", count);//Расчет количества четных чисел
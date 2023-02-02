// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

//Метод генерации массива
int[] GenArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

//Метод печатает массив
void Print1DArr(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

//Метод вывода результата
void PrintData(string msg, int res)
{
    Console.WriteLine(msg + res);
}

//Метод расчета суммы нечетных чисел
int SumOdd(int[] arr)
{
    int res = 0;
    int i = 1;
    while (i < arr.Length)
    {
        res += arr[i];
        i = i + 2;
    }
    return res;
}

int[] array = GenArray(10, -9, 10); //Генерация массива
Print1DArr(array); //Печать массива
int sumOdd = SumOdd(array); //Расчет суммы нечетных чисел
PrintData("Сумма нечетных чисел равна : ", sumOdd); //Печать суммы нечетных чисел
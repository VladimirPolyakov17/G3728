// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//Метод генерации массива
double[] GenArray(int len)
{
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100, 100) + new Random().NextDouble();
    }
    return arr;
}

//Метод печатает массив
void Print1DArr(double[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1]);
}

//Метод вывода результата
void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

//Метод находит разницу между максимальным и минимальным значением элементов массива.
double MinMax(double[] arr)
{
    double minMax = 0;
    double min = double.MaxValue;
    double max = double.MinValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    return minMax = max - min;
}

double[] array = GenArray(4); //Генерация массива
Print1DArr(array); //Печать массива
double minMax = MinMax(array);
PrintData("Разница между максимальным и минимальным значением элементов массива равна : ", minMax);
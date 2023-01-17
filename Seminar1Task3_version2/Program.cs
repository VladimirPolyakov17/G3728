//Задача №3
//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//Например: 
//3 -> Среда
//5 -> Пятница

//Считываем данные с консоли 
string? imputLine = Console.ReadLine();
// Проверяем, чтобы данные не были пустыми
if (imputLine != null)
{
//Вариант 2
int imputNumber = int.Parse(imputLine);
string outDayOfWeek = string.Empty;
switch (imputNumber)
{
case 1: outDayOfWeek = "понедельник"; break;
case 2: outDayOfWeek = "вторник"; break;
case 3: outDayOfWeek = "среда"; break;
case 4: outDayOfWeek = "четверг"; break;
case 5: outDayOfWeek = "пятница"; break;
case 6: outDayOfWeek = "суббота"; break;
case 7: outDayOfWeek = "воскресенье"; break;
default: outDayOfWeek = "это не день недели!"; break;
}
Console.WriteLine(outDayOfWeek);
}
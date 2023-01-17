string? imputLine = Console.ReadLine();
if (imputLine != null)
{

    int imputNumber = int.Parse(imputLine);
 
    string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(imputNumber));
    Console.WriteLine(outDayOfWeek);
}

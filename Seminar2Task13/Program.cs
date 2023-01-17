//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. 
//Если второе число некратно первому, то программа выводит остаток от деления.

int num1 = int.Parse(Console.ReadLine()??"0"); 
int num2 = int.Parse(Console.ReadLine()??"0");
int result = num2%num1;
if(result==0) 
{     
  Console.WriteLine("Кратное"); 
}
else 
{ 
  Console.WriteLine("Не кратно "+result); 
}
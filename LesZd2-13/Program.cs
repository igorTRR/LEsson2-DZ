// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

while(n>999)   
{
n = n/10;
}

int k = n%10; 
if (n<99)
{
     Console.Write("Нет цифры !");
}
   else
   {
  Console.Write($"{k}"!);
   }

     
      



 


   
    
  






    

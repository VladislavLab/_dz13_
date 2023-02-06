//Задача 13: Напишите программу, которая выводит третью
//цифру заданного числа или сообщает,что третьей цифры нет.

Console.Clear();
Console.Write("Введите число  ");
int num = int.Parse(Console.ReadLine()!);

if (num>99)
{
  while (num>999)
  {
    num/=10;
    
  }
  int i= num%10;
  Console.Write($" {i} ");
}
else{
  Console.Write("нет 3й цифры ");
}
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите положительное число");

int num = int.Parse(Console.ReadLine());

double digit = Math.Log10(num);
Console.WriteLine (digit);
digit = (int)digit;
Console.WriteLine (digit);

if (digit > 1)
{
    int count = 1;
    int res = num;
    Console.WriteLine (res);
    while (count < digit - 1)
    {
        res = res/10;
        count ++;
     }
     Console.Write("Третья цифра в числе: ");
    Console.Write(num);
    Console.Write(", равняется: ");
    Console.WriteLine(res%10);
}
else
{
    Console.Write("Третья цифра в числе: ");
    Console.Write(num);
    Console.WriteLine(", отсутствует!");
}
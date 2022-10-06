// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


Console.Clear();

Console.WriteLine("Введи первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

int b = (a % 100) / 10;

Console.WriteLine("Второе число: ");
Console.WriteLine(b);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Можно воспользоваться нумерацией строк, но необязательно)


Console.Clear();

int a = new Random().Next(0, 100000);
Console.Write("Случайное число: ");
Console.WriteLine(a);

int b = (a / 100) % 10;
int c = (a / 10) % 10;
int d = (a % 10); 

if (a > 10000)
{Console.Write("Третья цифра: ");
Console.WriteLine(b);}

else if (a > 1000)
{Console.Write("Третья цифра: ");
Console.WriteLine(c);}

else if (a > 100 && a < 1000)
{Console.Write("Третья цифра: ");
Console.WriteLine(d);}

else
Console.Write("Третий цифры нет!");


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.



Console.Clear();

Console.WriteLine("Введи день недели, и узнайте является он выходным: ");
int a = Convert.ToInt32(Console.ReadLine());

while (a < 1 || a > 7)
{ 
    Console.Write("Вы ошиблтсь! введите день недели: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(a);
}

if (a==1)
Console.WriteLine("Нет");

else if (a == 2)
Console.WriteLine("Нет");

else if (a == 3)
Console.WriteLine("Нет");

else if (a == 4)
Console.WriteLine("Нет");

else if (a == 5)
Console.WriteLine("Нет");

else if (a == 6)
Console.WriteLine("Да");

else if (a == 7)
Console.WriteLine("Да");
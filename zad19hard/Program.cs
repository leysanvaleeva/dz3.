// Задача 19 - HARD необязательная

// Напишите программу, которая принимает на вход целое число любой разрядности и 
// проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int n = 0;
System.Console.WriteLine(Reserve(n));

if (num == n)
{
    System.Console.WriteLine("Палиндром");
}
else
{
    System.Console.WriteLine("Не палиндром");
}


int Reserve(int n)
{
    while (num > 0)
    {
        int i = num % 10;
        n = (n * 10) + i;
        num /= 10;
    }
    System.Console.WriteLine($"{n}");
    return num;
}

// int i = 0;
// int j = 0;


// while (num > 0)
// {
//     num/=10;
//     count++;
// }
//   System.Console.WriteLine($"Количество цифр в числе {count} ");
// if (count < 2)
// {
// System.Console.WriteLine("В числе меньше двух цифр, полиндром невозможен");
// }
// if (count > 2)
// {

//  for (i = count-1; i>-1; i--)

//   for (j =i ; j<count-1; j++)

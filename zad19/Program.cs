// <!-- Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да -->


System.Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());

if (num>=10000)

    {
        int l1 = num / 10000;
        int m1 = num % 10;
 
            if(l1 == m1)
            {
                num /= 10;
                int l2 = num / 100 % 10;
                int m2 = num % 10;
                if(l2 == m2)
                    Console.WriteLine("Полиндром");
            }
            else 
            Console.WriteLine("Не полиндром");
            
    }
    else     Console.WriteLine("Некорректное число!");


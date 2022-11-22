//19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


Console.Write("ВВести число : ");
int number = Convert.ToInt32(Console.ReadLine());

if(number/10000 == number%10 && number/1000%10 == number/10%10)
{
    Console.WriteLine($"Число {number} является палиндромом ");
}

else if (number < 10000 || number > 99999)
{
    Console.WriteLine("условия не выполнены");
}

else  
{
    Console.WriteLine("нет");
}
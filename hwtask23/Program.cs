// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = 1;
while (num2 <= num)
{
    int num3 = num2 * num2 * num2;
    Console.WriteLine(num3);
    num2++;
}

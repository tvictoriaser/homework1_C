// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Введите 3 числа");

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

int max_number = number1;

if (max_number < number2)
{
    max_number = number2;
}

if (max_number < number3)
{
   max_number = number3; 
}

Console.WriteLine($"Максимальное число - {max_number}");
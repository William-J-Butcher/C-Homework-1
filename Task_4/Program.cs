// Задача 4: 
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int num3 = Convert.ToInt32(Console.ReadLine());
int numMax = num1;
if(num2 > numMax)
{
    numMax = num2;
}
if(num3 > numMax)
{
    numMax = num3;
}
Console.WriteLine($"Максимальное из трех чисел - {numMax}");


// Console.WriteLine("Введите первое число:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число:");
// int num3 = Convert.ToInt32(Console.ReadLine());

// if(num1 > num2 & num1 > num3)
// {
//         Console.WriteLine($"Максимальное из трех чисел - {num1}");
// }
// else if(num2 > num1 & num2 > num3)
// {
//         Console.WriteLine($"Максимальное из трех чисел - {num2}");
// }
// else if(num3 > num1 & num3 > num2)
// {
//         Console.WriteLine($"Максимальное из трех чисел - {num3}");
// }
// else if(num1 == num2 & num1 == num3)
// {
//         Console.WriteLine($"{num1} = {num2} = {num3} - вы ввели одинаковые числа");
// }

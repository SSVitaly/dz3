// №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
Console.Clear();
Console.WriteLine("Задача № 25");
Console.WriteLine("Введите число А:");
double A = double.Parse(Console.ReadLine());

Console.WriteLine("Введите число B:");
int B = int.Parse(Console.ReadLine());
double result = 1;
for (int i=0; i<B; i++)
{
    result = result*A;
}

Console.WriteLine($"Число {A} в степени {B} равно:");
Console.WriteLine($"{result:f3}");
Console.WriteLine();

//№ 27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Задача № 27");
Console.WriteLine("Введите число, сумму чисел которого нужно посчитать:");
int a = int.Parse(Console.ReadLine());
int sum = 0;

while (a != 0)
{
    sum += a%10;
    a /= 10;
}
Console.WriteLine(sum);
Console.WriteLine();

//№ 28 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.WriteLine("Задача № 28");
Console.WriteLine("Массив из 8 случайных чисел в диапазоне от -10 до 10:");
int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10,11);
    Console.Write($"{array[i]} ");
}
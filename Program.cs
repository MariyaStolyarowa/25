//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.Clear();
int A, B;
Console.WriteLine("Введите первое число: ");
A=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
B=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Math.Pow(A, B));
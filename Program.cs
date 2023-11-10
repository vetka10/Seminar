Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10 
// 8 -> 36

 Console.Write("Введите число А: ");
 int limit = Convert.ToInt32(Console.ReadLine());
// // Вызов метода
 Console.WriteLine($"Сумма чисел от 1 до {limit} = {GetSum(limit)}");
// // тип_метода ИмяМетода (параметр1, параметр2...параметрN)
 int GetSum (int A)
 {
     int sum = 0;
     // i = 1 - начало, 
     for (int i = 1; i <= A; i++)
     {
         sum += i; // sum = sum + i
     }
     return sum;
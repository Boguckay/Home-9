// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int GetNumber(string msg) 
//  { 
//      Console.Write(msg); 
//      int userNumber = Convert.ToInt32(Console.ReadLine());; 
//      return userNumber; 
//  } 
 
//  string StringRecursion(int number) 
//  { 
//     if (number == 1) return number.ToString(); 
     
//     return number + " " + StringRecursion(number - 1); 
//  } 
//  int userNumber = GetNumber("Введите число: "); 
//  Console.WriteLine(); 
//  Console.Write(StringRecursion(number: userNumber)); 

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: "); 
 int m = Convert.ToInt32(Console.ReadLine()); 
 
 Console.Write("Введите число N: "); 
 int n = Convert.ToInt32(Console.ReadLine()); 
 
 SumFromMToN(m, n); 
 
 void SumFromMToN(int m, int n) 
 { 
     Console.Write(SumMN(m - 1, n)); 
 } 
     int SumMN(int m, int n) 
 { 
     int res = m; 
     if (m == n) 
         return 0; 
     else 
     { 
         m++; 
         res = m + SumMN(m, n); 
         return res; 
     } 
 } 



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

// Console.Write("Введите число M: "); 
//  int m = Convert.ToInt32(Console.ReadLine()); 
 
//  Console.Write("Введите число N: "); 
//  int n = Convert.ToInt32(Console.ReadLine()); 
 
//  SumFromMToN(m, n); 
 
//  void SumFromMToN(int m, int n) 
//  { 
//      Console.Write(SumMN(m - 1, n)); 
//  } 
//      int SumMN(int m, int n) 
//  { 
//      int res = m; 
//      if (m == n) 
//          return 0; 
//      else 
//      { 
//          m++; 
//          res = m + SumMN(m, n); 
//          return res; 
//      } 
//  } 



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int m = InputNumbers("Введите m: "); 
int n = InputNumbers("Введите n: "); 
 
 int functionAkkerman = Ack(m, n); 

 Console.Write($"Функция Аккермана = {functionAkkerman} "); 
 
 int Ack(int m, int n) 
 { 
   if (m == 0) return n + 1; 
   else if (n == 0) return Ack(m - 1, 1); 
   else return Ack(m - 1, Ack(m, n - 1)); 
 } 
 
 int InputNumbers(string input)  
 { 
   Console.Write(input); 
   int output = Convert.ToInt32(Console.ReadLine()); 
   return output; 
 } 

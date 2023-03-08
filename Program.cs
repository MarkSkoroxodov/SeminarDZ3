// Console.Clear();
// int x1 = InputNumber("Введите x1: ");
// int y1 = InputNumber("Введите y2: ");
// int z1 = InputNumber("Введите z2: ");
// int x2 = InputNumber("Введите x1: ");
// int y2 = InputNumber("Введите y2: ");
// int z2 = InputNumber("Введите z2: ");

// Console.WriteLine($"Расстояние между точками ({x1}, {y1}, {z1})  и ({x2}, {y2}, {z2}) {CalculateDistance(x1, y1, z1, x2, y2, z2)}");

// static int InputNumber(string message)
// {
//     try
//     {
//         Console.Write(message);
//         return (int.Parse(Console.ReadLine() ?? ""));
//     }
//     catch (Exception exc)
//     {
//         Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
//         return 0;
//     }
// }

// static double CalculateDistance(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     return Math.Sqrt(Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2) + (Math.Pow(z2 - z1, 2))));
// }


// using System;
// class HelloWorld {
//   static bool isPal(int n)
//   {
//       int r=0,nn=n;
//       while (n>0)
//       {
//           r=r*10+n%10;
//           n=n/10;
//       }
//       return r==nn;
//   }
//   static void Main() 
//   {
//     int n;  
//     Console.Write("Введите пятизначное число: ");
//     n=Convert.ToInt32(Console.ReadLine());
//     if (isPal(n))
  
//        Console.WriteLine("Палиндром");
//     else   
//        Console.WriteLine("Не палиндром");
//   }
// }


// Console.Write("Введите число N: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Таблица кубов:\n");
// for (int i=1;i<=a;i++)
// {
// int b = i*i*i;
// Console.Write($"{b}, ");
// }
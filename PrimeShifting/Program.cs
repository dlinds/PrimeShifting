using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Primes
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

      host.Run();
    }
  }
}

// using System;
// using System.Collections.Generic;
// using Primes.Models;
// namespace Primes
// {
//   public class Program
//   {
//     public static void Main()
//     {
//       Console.WriteLine("Enter a number");
//       int input = int.Parse(Console.ReadLine());
//       List<int> numList = new List<int>();
//       for (int x = 2; x <= input; x++)
//       {
//         numList.Add(x);
//       }
//       for (int n = 2; n <= input; n++)
//       {
//         for (int x = 2; x < n; x++)
//         {
//           if ((n % x) == 0)
//           {
//             numList.Remove(n);
//           }
//         }
//       }
//       numList.Sort();
//       foreach (int number in numList)
//       {
//         Console.WriteLine(number);
//       }
//     }
//   }
// }



// PS C:\Users\DanielLindsey\Desktop\C#\PrimeShifting.Solution\PrimeShifting> dotnet run
// Enter a number
// 100
// 2 
// 3 
// 5 
// 7 
// 11
// 13
// 17
// 19
// 23
// 29
// 31
// 37
// 41
// 43
// 47
// 53
// 59
// 61
// 67
// 71
// 73
// 79
// 83
// 89
// 97
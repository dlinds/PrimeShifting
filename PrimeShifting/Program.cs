using System;
using System.Collections.Generic;
using Primes.Models;
namespace Primes
{
  public class Program
  {
    /*
      Get number from the user -> n
      for loop that starts at 2 and ends at n to add the numbers in the list
      For each through the list to remove the multiples of 2 except the number 2
      */
    public static void Main()
    {
      Console.WriteLine("Enter a number");
      int input = int.Parse(Console.ReadLine());
      // List<int> primeList;
      List<int> numList = new List<int>();
      for (int x = 2; x <= input; x++)
      {
        numList.Add(x);
      }
      for (int n = 2; n <= input; n++)
      {
        //primeList.Add(2);
        if ((n % 2) == 0)
        //|| (n % 3) == 0 || (n % 4) == 0)
        {
          numList.Remove(n);

        }
        if ((n % 3) == 0)
        {
          numList.Remove(n);

        }
        if ((n % 5) == 0)
        {
          numList.Remove(n);

        }
        if ((n % 7) == 0)
        {
          numList.Remove(n);

        }

      }
      //list 1-100
      //newlist--->add 2
      numList.Add(2);
      numList.Add(3);
      numList.Add(5);
      numList.Add(7);
      numList.Sort();
      foreach (int number in numList)
      {
        Console.WriteLine(number);
      }

    }

  }
}



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
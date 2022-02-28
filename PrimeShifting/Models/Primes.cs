using System;
using System.Collections.Generic;


namespace Primes.Models
{
  public class Prime
  {
    public int UserNumber { get; set; }
    public string PrimesOutput { get; set; }

    public void GetPrimes()
    {
      List<int> numList = new List<int>();
      for (int x = 2; x <= UserNumber; x++)
      {
        numList.Add(x);
      }
      for (int n = 2; n <= UserNumber; n++)
      {
        for (int x = 2; x < n; x++)
        {
          if ((n % x) == 0)
          {
            numList.Remove(n);
          }
        }
      }
      numList.Sort();
      string output = "";
      foreach (int number in numList)
      {
        output += number + ", ";
      }
      PrimesOutput = output;
    }
  }
}
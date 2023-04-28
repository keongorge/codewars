using System;
using System.Collections.Generic;

public static class Kata
{
  public static int DescendingOrder(int num)
  {
    // Bust a move right here
    if(num < 1){
      return 0;
    }
    
    List<int> digits = new List<int>();
    int digit;
    while(num > 0)
    {
      digit = num % 10;
      digits.Add(digit);
      num = num / 10;
    }
    digits.Sort();
    digits.Reverse();
    List<string> convert = digits.ConvertAll<string>(x => x.ToString());
    string newNum = String.Join("", convert);
    int finalNum = Int32.Parse(newNum.Trim());
    return finalNum;
  }
}

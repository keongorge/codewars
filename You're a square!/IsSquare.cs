using System;

public class Kata
{
  public static bool IsSquare(int n)
  {
    double root = Math.Sqrt(n);
    if(root == (int)root){
      return true;
    }else{
      return false;
    }
  }
}

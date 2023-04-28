public class Kata
{
  public static int FindShort(string s)
  {
    string[] words = s.Split(" ");
    int smallest = -1;
    foreach(string word in words)
    {
      if(smallest < 0){
        smallest = word.Length;
      }else if(word.Length < smallest){
        smallest = word.Length;
      }
      
    }
    return smallest;
  }
}

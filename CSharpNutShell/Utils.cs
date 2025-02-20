class Utils
{
  static int num = 0;
  public static void SayStuff()
  {
    num++;
    WriteLine($"Utils.SayStuff: {num} times");
  }
}

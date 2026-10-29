using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Random random = new Random();
      int key = random.Next(1, 25);

      int i = 0;
      Console.Write("What is your message? "); string message = Console.ReadLine();

      char[] array = message.ToCharArray(); //splits message into a array

      while (i < array.Length)
      {
        array[i] = (char)(array[i] + key);
        i++;
      }

      i = 0;
      Console.Write("Your encrypted message is: ");
      while (i < array.Length)
      {
        Console.Write(array[i]);
        i++;
      }
    }
  }
}

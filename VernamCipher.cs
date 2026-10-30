using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      //Vernam Cipher

      int i = 0;
      string message = "Hello";
      string Pad = "ZODGH";

      if (Pad.Length < message.Length)
      {
        Console.WriteLine("Pad is shorter than the message.");
        Console.WriteLine("Please provide a pad that is at least as long as the message."); Pad = Console.ReadLine();
      }

      for (i = 0; i < Pad.Length; i++)    
      {
        char keyB = Pad[i];
        char messageB = message[i];

        char encrypted = (char)(messageB ^ keyB);
        Console.Write(encrypted);
      }
    }
  }
}

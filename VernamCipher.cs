using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vernam Cipher

            string message = "HELLO"; //message to be encrypted
            string OneTimePad = "ZODGH"; //key being used to encrypt the message

            if (message.Length < OneTimePad.Length) //checks if the message is shorter than the key
            {
                Console.WriteLine("Message is too short!");
                Console.WriteLine("Please enter a new message : "); message = Console.ReadLine(); //new message 
            }
            //for some reason, the asignment made it so I had to check the length of the Pad and Message depsite me being given a pre assigned
            //message and key


            for (int i = 0; i < message.Length;) //standard for loop
            {
                char temp1 = message[i];
                char temp2 = OneTimePad[i];

                char temp3 = (char)(temp1 ^ temp2); //does the XOR operation on the 2 variables, result in new variable 

                int encryptedMessage = (int)temp3; //converts a char into an integer
                Console.Write((int)encryptedMessage); //prints the encyrpted messages 
                i++;
            }
        }
    }
}

using System;
public class Program
{
    static void Main()
    {
        string text;
        Console.Write("Enter your cipher: ");
        text = Console.ReadLine();

        Cipher cipher = new Cipher(text);

        cipher.Results();
        cipher.FindPolish();
    }
}
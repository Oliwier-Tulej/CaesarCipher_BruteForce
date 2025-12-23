using System;
public class Cipher
{
    private string text;
    private string[] results = new string[25];
    public Cipher(string text)
    {
        this.text = text;
    }

    private void Decode()
    {
        for (int i = 0; i < 25; i++) // for each key
        {
            string new_result = "";
            for (int j = 0; j < text.Length; j++) // for each letter
            {
                int character = text[j];
                if ((character >= 65) && (character <= 90))
                {
                    character = character + i + 1;
                    if (character > 90)
                        character = character - 90 + 64;
                }
                else if ((character >= 97) && (character <= 122))
                {
                    character = character + i + 1;
                    if (character > 122)
                        character = character - 122 + 96;
                }
                new_result += (char)character;
            }
            results[i] = new_result;
        }
    }
    
    public void Results()
    {
        Decode();
        int i = 1;
        foreach (string s in results)
        {
            Console.WriteLine(i++ + ": " + s);
        }
    }
}
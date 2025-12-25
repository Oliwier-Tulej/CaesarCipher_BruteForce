using System;
using Lingua;
using static Lingua.Language;
public class Cipher
{
    private string[] results = new string[26];
    public Cipher(string text)
    {
        results[0] = text;
        Decode();
    }

    private void Decode()
    {
        for (int i = 1; i < 26; i++) // for each key
        {
            string new_result = "";
            for (int j = 0; j < results[0].Length; j++) // for each letter
            {
                int character = results[0][j];
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
        for (int i = 1; i < results.Length; i++)
        {
            Console.WriteLine("Result " + i + ": " + results[i-1]);
        }
        Console.WriteLine();
    }

    public void FindPolish()
    {
        var detector = LanguageDetectorBuilder.FromAllLanguages().Build();

        foreach (string r in results)
        {
            var detectedLanguage = detector.DetectLanguageOf(r);
            if (Equals(Polish, detectedLanguage))
            {
                Console.WriteLine("Possible polish message: " + r);
                FindEmail(r);
            }
        }
    }

    public void FindEmail(string text)
    {
        int lastSpace = -1;
        int lastSign = -1;
        bool isAtFound = false;
        for (int i = 0; i < text.Length; i++)
        {
            int currentSign = text[i];

            if (isAtFound)
            {
                if(currentSign == 32)
                {
                    lastSign = i-1;
                    break;
                }
                if (i == text.Length - 1)
                {
                    lastSign = i;
                }
            }
            else
            {
                if (currentSign == 64)
                {
                    isAtFound = true;
                }
                else if(currentSign == 32)
                {
                    lastSpace = i;
                }
            }
        }

        if (lastSign > lastSpace)
        {
            Console.Write("Possible email: ");
            for (int i = lastSpace + 1; i < lastSign + 1; i++)
            {
                Console.Write(text[i]);
            }
            Console.WriteLine(); 
        }
        else
        {
            Console.WriteLine("Email not found");
        }
    }
}
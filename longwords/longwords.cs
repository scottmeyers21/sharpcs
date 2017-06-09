using System;
using System.Collections.Generic;

public class Hello
{
    static string text()
    {
        return "After you get Mono installed, it’s probably a good idea to run a quick Hello World program to make sure everything is set up properly. That way you’ll know that your Mono is working before you try writing or running a more complex application.";
    }

    static List<string> longwords(int n, string text)
    {
        // return all words longer than n letters
        List<string> words = new List<string>();

        return words;
    }

    static public void Main()
    {
        string t = text();

        List<string> words = longwords(8, t);
        Console.WriteLine("long words are:");

        // write all the long words, one on each line
    }
}

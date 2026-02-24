using System;

class DefaultValues
{
    int number;
    bool flag;
    string text;

    public void ShowDefaults()
    {
        Console.WriteLine($"number: {number}");
        Console.WriteLine($"flag: {flag}");
        Console.WriteLine($"text: {(text == null ? "null" : text)}");

    }
}


using System;

class Player
{
    string Name;
    static int count;
    public Player(string n)
    {
        Name = n;
        Console.WriteLine($"{Name}");
        count++;
    }
    public static void totalCount()
    {
    
        Console.WriteLine($"총 플레이어 수: {count}");
    }
}


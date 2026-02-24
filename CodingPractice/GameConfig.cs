using System;

class GameConfig
{
    readonly string version = "1.0.0";
   int maxPlayers;

    public GameConfig(int max)
    {
       maxPlayers =max;
    }

    public void ShowConfig()
    {
        Console.WriteLine($"버전: {version}");
        Console.WriteLine($"최대 플레이어: {maxPlayers}");
    }
}


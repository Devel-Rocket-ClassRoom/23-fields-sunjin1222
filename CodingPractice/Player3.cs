using System;

class Player
{
    private string name;
    private int Level;



    public void SetInfo(string name, int Level)
    {
        this.name = name;
        this.Level = Level;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"이름: {name}");
        Console.WriteLine($"레벨: {Level}");
    }
}


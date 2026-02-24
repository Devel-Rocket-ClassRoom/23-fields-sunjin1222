using System;

class Character
{ 
    private string Name;
    private int Level;

    public void SetFnfo(string n, int lv)
    {
        Name=n;
        Level = lv;
    }
    public void ShowInfo()
    {
        Console.WriteLine($"이름: {Name}");
        Console.WriteLine($"레벨: {Level}");
    }
}


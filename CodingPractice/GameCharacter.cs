using System;

class GameCharacter

{
    string Name { get; }
    const int MaxHelth=100;
    int Attack;
    int nowHelth;
    static int count;

    public GameCharacter(string name, int attack)
    {
        Name = name;
        Attack = attack;
        nowHelth = MaxHelth;
        count++;
    }

    public void takedamage(int damage)
    {
        nowHelth -= damage;
        if (nowHelth < 0)
        {
            nowHelth = 0;
        }
        Console.WriteLine($"{Name}이(가)" +
            $"{damage} 데미지를 받음 남은체력:{nowHelth}");
       
    }

    public static void totalcount()
    {
        Console.WriteLine($"총 캐릭터 수:{count}");
    }
    public void showhero()
    {
        Console.WriteLine($"==={Name}===");
        Console.WriteLine($"체력: {nowHelth}/{MaxHelth}");
        Console.WriteLine($"공격력: {Attack}");
    }

}


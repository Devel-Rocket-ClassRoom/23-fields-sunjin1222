using System;

class Person
{
    readonly string Name = "홍길동";
    const int age = 21;
    readonly string nick = "길동이";
    readonly string[] site = { "네이버","구글"};

    public void ShowProfile()
    {
        Console.WriteLine($"이름: {Name}");
        Console.WriteLine($"나이: {age}");
        Console.WriteLine($"닉네임: {nick}");
        Console.WriteLine($"사이트: {string.Join((","),site)}");

    }

}


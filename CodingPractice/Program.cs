using System;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine();
/*
// 과제 1: 필드가 있는 클래스 만들기
Player player = new Player();
player.ShowStatus();

// 과제 2: public 필드
Character car=new Character();
car.Name="용사";
car.Level=10;
Console.WriteLine(car.Name);
Console.WriteLine(car.Level);


// 과제 3: private 필드
Character hero =new Character();
hero.SetFnfo("용사", 10);
hero.ShowInfo();
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


// 과제 4: 선언과 동시에 초기화
Player ch4 = new Player();
ch4.ShowStatus();

class Player
{ 
    private string name="이름없음";
    private int health=100;
    private int lv=1;

    public void ShowStatus()
    {
        Console.WriteLine($"이름: {name}");
        Console.WriteLine($"체력: {health}");
        Console.WriteLine($"레벨: {lv}");
    }
}


// 과제 5: 필드 이니셜라이저
Say say1 = new Say();
say1.Hi();

class Say
{
    private string message = "안녕하세요";

    public void Hi()
    {
        message = "반갑습니다";
        Console.WriteLine($"{message}");
    }
}



// 과제 6: 배열 필드 초기화
Schedule days6=new Schedule();
days6.PrintWeekDays();

class Schedule
{
    string[] days = { "sun", "mon", "tue", "wed", "thu", "fri", "sat" };

    public void PrintWeekDays()
    {
        foreach(string day in days )
        {
            Console.Write($"{day}\t");
        }
    
    }
}


// 과제 7: 기본값 확인
DefaultValues de = new DefaultValues();
de.ShowDefaults();
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


// 과제 8: 정적 필드 선언과 사용
Counter count1=new Counter();
count1.count1();
Counter count2 = new Counter();
count2.count1();
Counter count3 = new Counter();
count3.count1();

class Counter
{
    public static int count;

    public void count1()
    {
        count++;
        Console.WriteLine($"현재카운트: {count}");

    }
}



// 과제 9: 인스턴스 필드 vs 정적 필드
Player hero1=new Player("용사");
Player hero2 = new Player("마법사");
Player hero3 = new Player("궁수");
Player.totalCount();

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



// 과제 10: readonly 필드
GameConfig game = new GameConfig(4);
game.ShowConfig();

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

// 과제 11: readonly vs const 비교
Example example = new Example();
example.ShowValues();


// 과제 12: this 키워드

Player player = new Player();
player.SetInfo("용사", 10);
player.ShowInfo();

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


// 과제 13: 다양한 필드 타입 활용
Person person = new Person();
person.ShowProfile();


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
*/

// 과제 14: 게임 캐릭터 클래스

class GameCharacter

{
    string Name;
    int MaxHelth;
    int attack;


}


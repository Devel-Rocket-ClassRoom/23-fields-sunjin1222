using System;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine();

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


// 과제 4: 선언과 동시에 초기화
Player ch4 = new Player();
ch4.ShowStatus();


// 과제 5: 필드 이니셜라이저
Say say1 = new Say();
say1.Hi();



// 과제 6: 배열 필드 초기화
Schedule days6=new Schedule();
days6.PrintWeekDays();


// 과제 7: 기본값 확인
DefaultValues de = new DefaultValues();
de.ShowDefaults();


// 과제 8: 정적 필드 선언과 사용
Counter count1=new Counter();
count1.count1();
Counter count2 = new Counter();
count2.count1();
Counter count3 = new Counter();
count3.count1();



// 과제 9: 인스턴스 필드 vs 정적 필드
Player hero1=new Player("용사");
Player hero2 = new Player("마법사");
Player hero3 = new Player("궁수");
Player.totalCount();



// 과제 10: readonly 필드
GameConfig game = new GameConfig(4);
game.ShowConfig();

// 과제 11: readonly vs const 비교
Example example = new Example();
example.ShowValues();


// 과제 12: this 키워드

Player player = new Player();
player.SetInfo("용사", 10);
player.ShowInfo();


// 과제 13: 다양한 필드 타입 활용
Person person = new Person();
person.ShowProfile();


// 과제 14: 게임 캐릭터 클래스

GameCharacter hero1 = new GameCharacter("용사",15);
GameCharacter hero2 = new GameCharacter("마법사", 25);
hero1.showhero();
hero2.showhero();

hero1.takedamage(30);
hero1.takedamage(50);
hero1.takedamage(50);

GameCharacter.totalcount();


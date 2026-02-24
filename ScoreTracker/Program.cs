using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");
ScoreTracker score = new ScoreTracker("수학");

score.ShowScore();
score.SetScore(85);
score.AddBonus(10);
score.AddBonus(20);
score.ShowScore();




class ScoreTracker
{
    const int MaxScore = 100;
    const int MinScore = 0;
    string subjects {get;}
    private int score = 0;
    private int bonus = 0;

    public ScoreTracker(string subjects)
    {
        this.subjects = subjects;
    }

    public void SetScore(int score)
    {
        if (score > MaxScore || score < MinScore)
        {
            Console.WriteLine("점수는 0~100 사이여야 합니다");
        }
        else
        {
            this.score = score;
            Console.WriteLine($"점수를 {score}점으로 설정했습니다.");
        }
    }

    public void AddBonus(int addbonus)
    {
        score += addbonus;
        
        if (score > MaxScore)
        {
            score = MaxScore;
            Console.Write($"{addbonus}점 보너스 적용! 현재점수: {score}");
            Console.WriteLine(" (최대 점수 도달)");
        }
        else
        {
           Console.WriteLine($"{addbonus}점 보너스 적용! 현재점수: {score}");

        }
        bonus++;
    }

    public void ShowScore()
    {
        Console.WriteLine($"==={subjects}===");
        Console.WriteLine($"점수: {score} /{MaxScore} ");
        Console.WriteLine($"보너스 적용 횟수: {bonus}");
    }



}




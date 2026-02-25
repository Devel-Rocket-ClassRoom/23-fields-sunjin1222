using System;

class ScoreTracker
{
    const int k_MaxScore = 100;
    const int k_MinScore = 0;
    string subjects {get;}
    private int score = 0;
    private int bonus = 0;

    public ScoreTracker(string subjects)
    {
        this.subjects = subjects;
    }

    public void SetScore(int score)
    {
        if (score > k_MaxScore || score < k_MinScore)
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
        

        score = Math.Min(score + addbonus, k_MaxScore,);
        Console.WriteLine($"{addbonus}점 보너스 적용! 현재점수: {score}점");
        bonus++;
    }

    public void ShowScore()
    {
        Console.WriteLine($"==={subjects}===");
        Console.WriteLine($"점수: {score} /{k_MaxScore} ");
        Console.WriteLine($"보너스 적용 횟수: {bonus}");
    }



}




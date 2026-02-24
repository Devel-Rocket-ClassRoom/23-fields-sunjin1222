using System;

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


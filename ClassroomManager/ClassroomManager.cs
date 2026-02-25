using System;

class ClassroomManager
{
    const int k_maxstudent = 5;
    string classroom;
    private string[] students = {};
    int nowstudent=0;
    static int allclassroom;

    public ClassroomManager(string classroom)
    {
        this.classroom = classroom;
        students = new string[k_maxstudent];
        allclassroom++;
    }

    public void AddStudent(string name)
    {
        if (nowstudent >= k_maxstudent)
        {
            Console.WriteLine("정원이 가득 찼습니다.");
            return;
        }
        students[nowstudent]=name;
        nowstudent++;
    }

    public void ShowStudents()
    {
        Console.WriteLine($"{classroom}반 학생목록({nowstudent}/{k_maxstudent})");
        for (int i = 0; i < nowstudent; i++)
        {
            Console.WriteLine($"{i+1}.{students[i]}");
        }
 


    }

    public static void ShowTotalClassrooms()
    {
        Console.WriteLine($"전체 교실수: {allclassroom}");
    }




}

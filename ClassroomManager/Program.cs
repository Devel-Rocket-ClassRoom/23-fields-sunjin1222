using System;

// README.md를 읽고 아래에 코드를 작성하세요.
ClassroomManager class1 = new ClassroomManager("1반");
class1.AddStudent("홍길동");
class1.AddStudent("김철수");
class1.AddStudent("이영희");

ClassroomManager class2 = new ClassroomManager("2반");
class2.AddStudent("박민수");
class2.AddStudent("정수진");


class1.ShowStudents();
Console.WriteLine();
class2.ShowStudents();
Console.WriteLine();
ClassroomManager.ShowTotalClassrooms();


class ClassroomManager
{
    const int maxstudent = 5;
    string classroom;
    private string[] students = {};
    int nowstudent=0;
    static int allclassroom;

    public ClassroomManager(string classroom)
    {
        this.classroom = classroom;
        students = new string[maxstudent];
        allclassroom++;
    }

    public void AddStudent(string name)
    {
        if (nowstudent >= maxstudent)
        {
            Console.WriteLine("정원이 가득 찼습니다.");
            return;
        }
        students[nowstudent]=name;
        nowstudent++;
    }

    public void ShowStudents()
    {
        Console.WriteLine($"{classroom}반 학생목록({nowstudent}/{maxstudent})");
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

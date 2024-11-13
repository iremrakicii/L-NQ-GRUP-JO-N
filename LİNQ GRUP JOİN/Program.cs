using LİNQ_GRUP_JOİN;

class Program
{
    static void Main(string[] args)
    {
        List<Students> students = new List<Students>()
        {
            new Students(1,"Ali",1),
            new Students(2,"Ayşe",2),
            new Students(3,"Mehmet",3),
            new Students(4,"Fatma",4),
            new Students(5,"Ahmet",5)
        };

        List<Classes> classes = new List<Classes>()
        {
            new Classes(1,"Matematik"),
            new Classes(2,"Türkçe"),
            new Classes(3,"Kimya")

        };

        var studentsClasses = classes.GroupJoin(
                students,
                classItem => classItem.ClassId,
                student => student.ClassId,
                (classItem, studentsGroup) => new
                {
                    ClassName = classItem.ClassName,
                    Students = studentsGroup.Select(student => student.StudentName)
                });

        foreach (var classGroup in studentsClasses)
        {
            Console.WriteLine($"Sınıf Adı: {classGroup.ClassName}");
            foreach (var studentName in classGroup.Students)
            {
                Console.WriteLine($"Öğrenci adı:{studentName}");
            }


        }
    }
}

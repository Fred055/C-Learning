Student[] studentArray = { };

Yarat();
Yarat();
Yarat();
Yarat();
Yarat();

void Yarat()
{
    Console.WriteLine("Pls add student name:");
    Student student = new Student();
    student.Name = Console.ReadLine();

    Array.Resize(ref studentArray, studentArray.Length + 1);
    studentArray[studentArray.Length - 1] = student;

    void TelebeleriGoster()
    {
        Console.WriteLine("Student List");

        foreach (var student in studentArray)
        {
            Console.WriteLine(student.Name);
        }
    }
}

    class Student
    {
        public string Name { get; set; }

    }


   


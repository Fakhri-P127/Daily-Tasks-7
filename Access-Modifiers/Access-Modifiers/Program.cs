using System;

namespace Access_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        { 
            Student student1 = new Student("Fakhri","Afandiyev");
            Student student2 = new Student("Kamran", "Abilov");
            Student student3 = new Student("Gunel", "Soyadi");
            Student student4 = new Student("Cahangir", "Soyadi");
            Student student5 = new Student("Leon", "Kennedy");
            Group group = new Group("P127", 4);      
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);
            group.AddStudent(student4);
            group.AddStudent(student5);
            Student[] students = group.GetStudens();        
            
            foreach (Student student in students)
            {                              
                Console.WriteLine(student.GetFullname());
            }            
        }
    }
}

//8. Implement simple inheritance heirarchy with a base class and two derives class and display property of parent class


using System;
namespace Inheritance
{
    class Program{
        class School
        {
            public string subject = "Dot net";
            public string teacher = "Ram shah";

            public string DisplaySubject()
            {
                return subject;
            }
            public string DisplayTeacher() { 
            return teacher; 
            }
        }
        class Teacher:School { }
        class Subject:School { }    

        static void Main(string[] args)
        {
            Teacher myTeacher = new Teacher();
           Subject mySub = new Subject();
            string TeacherName=myTeacher.DisplayTeacher();
           string SubjectName= mySub.DisplaySubject();
            Console.WriteLine(TeacherName);
            Console.WriteLine(SubjectName);
        }
}
}
/*
using System;
namespace Inheritance
{
    class Program
    {

        class Vechile
        {
            public string brand = "Ford";
            public void Horn()
            {
                Console.WriteLine("Tui Tui!!!");
            }
        }

        class Car : Vechile
        {
            public string model = "Mustang";
        }

        class Van : Vechile
        {
            public string model_name= "EcoSport";
        }

        static void Main(string[] args) {
            Car mycar = new Car();
            Van myvan = new Van();
            Console.WriteLine($"{mycar.brand} {mycar.model} " );
            Console.WriteLine($"{myvan.brand} {myvan.model_name} " );
            mycar.Horn();
            myvan.Horn  ();
        }
    }
}
*/
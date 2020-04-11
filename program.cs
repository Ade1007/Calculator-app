using System;

namespace LatihanInheritanceReal
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ronal", 19);
            person.GetNameAndAge();

            Teacher teacher = new Teacher("Bambang", 35, 190302, "Guru Bahasa Indonesia");
            teacher.GetNameAndAge();

            Student student = new Student("Rico", 21, 10506, "Ayanajkt48@gmail.com");
            student.GetNameAndAge();

            Console.ReadKey();

        }
    }
}


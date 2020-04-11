using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanInheritanceReal
{
    internal class Student
    {
        private string Nama;
        private int Umur;
        private int Id;
        private string Email;

        public void GetNameAndAge() => Console.WriteLine("Nama: {0} Umurnya: {1} ID: {2} Email: {3} ", Nama, Umur, Id, Email);
        public Student(string Nama, int Umur, int Id, string Email)
        {
            this.Nama = Nama;
            this.Umur = Umur;
            this.Id = Id;
            this.Email = Email;
        }
    }
}




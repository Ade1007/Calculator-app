using System;
namespace LatihanInheritanceReal
{
    internal class Person
    {
        private string Nama;
        private int Umur;
        private int Id;
        private string Status;
        private string Email;

        public void GetNameAndAge() => Console.WriteLine("Nama: {0} Umurnya: {1} ", Nama, Umur, Id, Status, Email);
        public Person(string Nama, int Umur)
        {
            this.Nama = Nama;
            this.Umur = Umur;
        }
    }
}
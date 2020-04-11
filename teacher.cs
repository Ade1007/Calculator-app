using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanInheritanceReal
{
    internal class Teacher
    {
        private string Nama;
        private int Umur;
        private int Id;
        private string Status;

        public void GetNameAndAge() => Console.WriteLine("Nama: {0} Umurnya: {1} ID: {2} Status: {3} ", Nama, Umur, Id, Status);
        public Teacher(string Nama, int Umur, int Id, string Status)
        {
            this.Nama = Nama;
            this.Umur = Umur;
            this.Id = Id;
            this.Status = Status;
        }
    }
}
















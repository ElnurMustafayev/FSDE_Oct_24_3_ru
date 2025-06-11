namespace GenericsApp.Models;

using GenericsApp.Models.Base;
using System;

class Student : UserBase
{
    public double AvgMark { get; set; }

    public Student(string name, DateTime birthDate, double avgMarks) : base(name, birthDate)
    {
        this.AvgMark = avgMarks;
    }
}
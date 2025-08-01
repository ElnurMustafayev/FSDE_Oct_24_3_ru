﻿namespace GettingStartedApp.Entities;

class Student
{
    public int Id { get; set; }
    public required string Fullname { get; set; }
    public required DateTime BirthDate { get; set; }
    public object CountryId { get; set; }
    public object GroupId { get; set; }

    public override string ToString()
    {
        return $"Student Info:\n" +
               $"- ID: {Id}\n" +
               $"- Full Name: {Fullname}\n" +
               $"- Birth Date: {BirthDate}\n" +
               $"- Country ID: {(CountryId)}\n" +
               $"- Group ID: {(GroupId)}";
    }
}
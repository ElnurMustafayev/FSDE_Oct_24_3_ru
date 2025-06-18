namespace EnumeratorsApp.Enumerators;

using EnumeratorsApp.Models;
using System.Collections;

class StudentsInGroupLinearEnumerator : IEnumerator<Student>
{
    protected int Counter { get; set; }
    protected List<Student> Students { get; set; }

    public Student Current => this.Students[Counter++];

    object IEnumerator.Current => Current;

    public StudentsInGroupLinearEnumerator(List<Student> students)
    {
        this.Counter = 0;
        this.Students = students;
    }

    public bool MoveNext()
    {
        if(this.Students.Count <= this.Counter)
        {
            this.Reset();
            return false;
        }

        return true;
    }

    public void Reset()
    {
        this.Counter = 0;
    }

    public void Dispose()
    {
    }
}
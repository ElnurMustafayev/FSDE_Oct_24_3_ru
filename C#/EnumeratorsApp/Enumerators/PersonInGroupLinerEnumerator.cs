namespace EnumeratorsApp.Enumerators;

using EnumeratorsApp.Models;
using System.Collections;

class PersonInGroupLinerEnumerator : IEnumerator<Person>
{
    protected const int START_ITERATION_INDEX = -1;
    protected int Counter { get; set; }
    protected Group Group { get; set; }

    public Person Current
    {
        get
        {
            if(this.Counter == START_ITERATION_INDEX)
            {
                this.Counter++;
                return this.Group.Teacher;
            }

            return this.Group.Students[this.Counter++];
        }
    }

    object IEnumerator.Current => Current;

    public PersonInGroupLinerEnumerator(Group group)
    {
        this.Group = group;
        this.Reset();
    }

    public bool MoveNext()
    {
        if(this.Counter == START_ITERATION_INDEX)
        {
            return true;
        }

        if (this.Group.Students.Count <= this.Counter)
        {
            this.Reset();
            return false;
        }

        return true;
    }

    public void Reset()
    {
        this.Counter = START_ITERATION_INDEX;
    }

    public void Dispose()
    {
    }
}
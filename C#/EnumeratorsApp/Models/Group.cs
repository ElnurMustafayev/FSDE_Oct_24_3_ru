using EnumeratorsApp.Enumerators;
using System.Collections;

namespace EnumeratorsApp.Models;

class Group : IEnumerable<Person> /*, IEnumerable<Student>*/
{
    private readonly IEnumerator<Student> studentEnumerator;
    public IEnumerator<Person> PersonEnumerator { get; private set; }
    public Teacher Teacher { get; set; }
    public List<Student> Students { get; set; }

    public Group()
    {
        this.Students = new List<Student>();
        //this.studentEnumerator = new StudentsInGroupLinearEnumerator(this.Students);
        //this.PersonEnumerator = new PersonInGroupLinerEnumerator(this);
    }

    public void SetEnumerator(IEnumerator<Person> enumerator)
    {
        this.PersonEnumerator = enumerator;
    }

    //public IEnumerator<Student> GetEnumerator()
    //{
    //    return this.studentEnumerator;
    //}

    public IEnumerator<Person> GetEnumerator()
    {
        return this.PersonEnumerator;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
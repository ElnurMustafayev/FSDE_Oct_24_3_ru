using EnumeratorsApp.Enumerators;
using EnumeratorsApp.Models;

var group = new Group();

group.Teacher = new Teacher("Bob");

group.Students.Add(new Student("Tural"));
group.Students.Add(new Student("Kamran"));
group.Students.Add(new Student("Asad"));
group.Students.Add(new Student("Umid"));

group.SetEnumerator(new PersonInGroupLinerEnumerator(group));

foreach (var person in group)
{
    Console.WriteLine(person);
}

//group.SetEnumerator(new PersonInGroupReverseEnumerator(group));

foreach (var person in group)
{
    Console.WriteLine(person);
}


//var nums = new List<int>();

//nums.Add(1);
//nums.Add(22);
//nums.Add(333);

//for (int i = 0; i < nums.Count; i++)
//{
//    var currentNum = nums[i];
//    Console.WriteLine($"{i + 1}: {currentNum}");
//}

//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}
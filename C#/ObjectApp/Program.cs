//var variable = new List<Tuple<Dictionary<int, string>, string>>();
//variable = "qwerty";
//Console.WriteLine(variable);



//dynamic d = 100;
//d = "qwerty";
//d = true;
////d.Bob();
//Console.WriteLine(d.ToUpper());



/*
object obj = 123;
obj = "qwerty";
obj = new object();
obj = new Random();
obj = true;
obj = new int[] { 1,2,3 };

Console.WriteLine(obj);
*/

using ObjectApp.Models;

object obj1 = new Person()
{
    Name = "Bob",
};

//obj1.ToString();
//obj1.GetType();
//obj1.GetHashCode();
//obj1.Equals(123);

object obj2 = new Person()
{
    Name = "Bob",
    BirthDate = new DateTime(1965, 10, 20),
};

Console.WriteLine(obj1.Equals(obj2));



//int[] arr = new int[] { 1, 2, 3 };

//object num1 = arr;
//object num2 = arr;

//Console.WriteLine(num1.GetHashCode());
//Console.WriteLine(num2.GetHashCode());


//Console.WriteLine(obj2);
//Console.WriteLine(obj2.ToString());


//Console.WriteLine(obj1.GetType());
//Console.WriteLine(obj2.GetType());

//Console.WriteLine(obj1.GetType() == obj2.GetType());
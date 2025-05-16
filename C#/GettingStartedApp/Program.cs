/*
Console.Write("Input your age: ");
string userAgeInput = Console.ReadLine();

int userAge = Convert.ToInt32(userAgeInput);

bool isAdult = userAge >= 18;

if(isAdult)
{
    Console.WriteLine("You are adult!");
}
else
{
    Console.WriteLine("You are not adult!");
}
*/



/*
int counter = 0;

while(counter < 10)
{
    if (counter == 3)
        //continue; 
        break; 

    counter++;

    
    Console.WriteLine(counter);
}
*/

bool IterationMethod(string text)
{
    Console.WriteLine(text);

    return true;
}


// ABDCBDCBDCBDCBDC
for (Console.WriteLine("A"); IterationMethod("B"); Console.WriteLine("C"))
{
    Console.WriteLine("D");
}


//for (CreateUser(); CheckUserInfo(); GetNextUser())
//{
//    PrintUserInfo();
//}
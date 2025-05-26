//int[] numbers = new int[3];
//numbers[1] = 100;

//int[] numbers = new int[3] { 100, 200, 333 };
//int[] numbers = new int[] { 100, 200, 333 };
//int[] numbers = { 100, 200, 333 };
//numbers[1] = 777;

//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine($"[{i}]: {numbers[i]}");
//}



//int[,] arr = new int[2, 3]
//{
//    { 1, 2, 3 },
//    { 3, 2, 1 },
//};

//Console.WriteLine(arr[1,2]);



//string[] names = new string[]
//{
//    "Kate",
//    "Bob",
//    "Ann",
//    "John",
//};

//for (int i = 0; i < names.Length; i++)
//{

//    Console.WriteLine($"{names[i]} - {names[i].Length} symbols");
//}



//int[] numbers =
//{
//    'B', 'o', 'b', 7, 7, 7,
//};

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}


/*
Random random = new Random();

for (int i = 0; i < 100; i++)
{
    //var randomNumber = random.Next(100);
    //var randomNumber = random.Next(1000, 9999);
    var randomNumber = random.Next(10);

    if(randomNumber < 5)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine($"{randomNumber} !!!");
    }
    else
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.WriteLine(randomNumber);
    }

    Console.ResetColor();
}
*/


// int[] arr = new int[8];


/*
void ChangeRandomElementToRandomValue(int[] nums)
{
    Random random = new Random();

    int randomIndex = random.Next(nums.Length);
    int randomValue = random.Next();

    nums[randomIndex] = randomValue;
}


void PrintArray(int[] nums)
{
    Console.WriteLine($"array length: {nums.Length}");
    for (int i = 0; i < nums.Length; i++)
    {
        Console.Write($"{nums[i]} ");
    }
    Console.WriteLine();
}

int[] arr = new int[3];

PrintArray(arr);
ChangeRandomElementToRandomValue(arr);
PrintArray(arr);
ChangeRandomElementToRandomValue(arr);
PrintArray(arr);
*/



/*
void FillAllNamesByUserInput(string[] names)
{
    Console.WriteLine("Input all names: ");
    for (int i = 0; i < names.Length; i++)
    {
        Console.Write($"{i + 1}/{names.Length}: ");
        names[i] = Console.ReadLine();
    }
}

void PrintAllNames(string[] names)
{
    Console.WriteLine("All names: ");
    for (int i = 0; i < names.Length; i++)
    {
        Console.WriteLine($"{i + 1}: {names[i]}");
    }
}

string[] names = new string[3];

FillAllNamesByUserInput(names);
PrintAllNames(names);
*/
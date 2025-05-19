/*
void PrintMessage(
    string message, 
    int repeatingCount = 1, 
    ConsoleColor backgroundColor = ConsoleColor.Black, 
    ConsoleColor foregroundColor = ConsoleColor.White) {

    Console.BackgroundColor = backgroundColor;
    Console.ForegroundColor = foregroundColor;
    for (int i = 0; i < repeatingCount; i++)
    {
        Console.WriteLine(message);
    }
    Console.ResetColor();
}
*/

/*
Console.Write("Print your message: ");
string message = Console.ReadLine();

Console.Write("Repeating count: ");
string repeatingCountStr = Console.ReadLine();
int repeatingCount = Convert.ToInt32(repeatingCountStr);

PrintMessage(message, repeatingCount);
*/

/*
Console.WriteLine("Start");

PrintMessage("one");
PrintMessage("two", backgroundColor: ConsoleColor.White);
PrintMessage("three", 3, ConsoleColor.Yellow, ConsoleColor.DarkRed);

Console.WriteLine("End");
*/









// пользователь вводит данные:
// баланс, наличие визы

// приложение вычисляет, может ли пользователь полететь в Америку

// Условие: В Америку могут полететь те люди у которых
// или баланс больше 100к или те, у которых есть виза



/*
bool CanGoToUsa(double balance, bool hasVisa)
{
    return balance > 100_000 || hasVisa;
}

Console.Write("Input your balance: ");
string balanceStr = Console.ReadLine();
double balance = double.Parse(balanceStr);

Console.Write("Do you have visa? (yes/no): ");
string hasVisaQuestionAnswerStr = Console.ReadLine();
bool hasVisa = hasVisaQuestionAnswerStr == "yes";

bool canGoToUsa = CanGoToUsa(balance, hasVisa);

if(canGoToUsa)
{
    Console.WriteLine("You can go to USA");
}
else
{
    Console.WriteLine("You can not go to USA");
}
*/







// ref, out, in

void ChangeValue(ref int numToChange)
{
    numToChange += 100;
    Console.WriteLine(numToChange);
}

int num = 777;
ChangeValue(ref num);
Console.WriteLine(num);
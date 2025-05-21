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



// ref
//void ChangeValue(ref int numToChange)
//{
//    numToChange += 100;
//    Console.WriteLine(numToChange);
//}

//int num = 777;
//ChangeValue(ref num);
//Console.WriteLine(num);

enum OperationTypes : int
{
    plus = 1,
    minus,
    divide, 
    multiply,
}

class Program
{
    public static void ChangeValue(out double result, double number, double valueToChange, in OperationTypes operationType)
    {
        if (operationType == OperationTypes.plus)
            result = number + valueToChange;
        else if (operationType == OperationTypes.minus)
            result = number - valueToChange;
        else if (operationType == OperationTypes.multiply)
            result = number * valueToChange;
        else if (operationType == OperationTypes.divide)
            result = number / valueToChange;
        else
            result = number;
    }

    public static OperationTypes GetOperationTypeByUserInput()
    {
        const OperationTypes defaultOperationType = OperationTypes.plus;
        Console.WriteLine("Operation type:");

        //Console.WriteLine("{0}: {1}", OperationTypes.plus, (int)OperationTypes.plus);
        Console.WriteLine($"{OperationTypes.plus}: {(int)OperationTypes.plus}");
        Console.WriteLine($"{OperationTypes.minus}: {(int)OperationTypes.minus}");
        Console.WriteLine($"{OperationTypes.divide}: {(int)OperationTypes.divide}");
        Console.WriteLine($"{OperationTypes.multiply}: {(int)OperationTypes.multiply}");
        Console.WriteLine();

        string operationTypeInput = Console.ReadLine();
        OperationTypes operationType = (OperationTypes)int.Parse(operationTypeInput);

        bool isInOperationsRange = OperationTypes.plus <= operationType && operationType <= OperationTypes.multiply;

        if (isInOperationsRange)
            return operationType;

        return defaultOperationType;
    }

    public static void Proceed(out double result, in double first, in double second)
    {
        OperationTypes operationType = GetOperationTypeByUserInput();

        switch (operationType)
        {
            case OperationTypes.plus:
                result = first + second;
                break;
            case OperationTypes.minus:
                result = first - second;
                break;
            case OperationTypes.divide:
                result = first / second;
                break;
            case OperationTypes.multiply:
                result = first * second;
                break;
            default:
                result = 0;
                break;
        }
    }

    public static void Main()
    {
        //OperationTypes operationType = OperationTypes.plus;

        //// out
        //double num = 4;
        //ChangeValue(out double result, num, valueToChange: 2, operationType);

        //Console.WriteLine(result);



        // 1.у пользователя спрашивается: операция(+, -,/, *), первое и второе числа
        // 2.на экран пользователя выводится результат(result) операции(в Main методе)
        // 
        // void Proceed(out double result, in double first, in double second);

        Console.Write("First number: ");
        double first = Convert.ToDouble(Console.ReadLine());

        Console.Write("Second number: ");
        double second = Convert.ToDouble(Console.ReadLine());

        Proceed(out double result, first, second);
        Console.WriteLine(result);
    }
}
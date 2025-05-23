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

using System.Collections.Generic;

enum OperationTypes : int
{
    plus = 1,
    minus,
    divide, 
    multiply,
    power,
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
    public static char GetOperationSymbol(in OperationTypes operationType)
    {
        switch (operationType)
        {
            case OperationTypes.plus:
                return '+';
            case OperationTypes.minus:
                return '-';
            case OperationTypes.divide:
                return '/';
            case OperationTypes.multiply:
                return '*';
            default:
                throw new NotImplementedException($"There is not symbol for operation: {operationType}");
        }
    }
    public static double GetOperationResult(in double first, in double second, in OperationTypes operationType)
    {
        switch (operationType)
        {
            case OperationTypes.plus:
                return first + second;
            case OperationTypes.minus:
                return first - second;
            case OperationTypes.divide:
                if (second == 0)
                    throw new DivideByZeroException();
                return first / second;
            case OperationTypes.multiply:
                return first * second;
            default:
                throw new NotImplementedException($"There is not calculation implementation for operation: {operationType}");
        }
    }
    public static double GetOperationResult(in double first, in double second, in OperationTypes operationType, out char operationSymbol)
    {
        operationSymbol = GetOperationSymbol(operationType);
        return GetOperationResult(first, second, operationType);
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
        Console.Write("Choose your operation: ");

        string operationTypeInput = Console.ReadLine();
        OperationTypes operationType = (OperationTypes)int.Parse(operationTypeInput);

        bool isInOperationsRange = OperationTypes.plus <= operationType && operationType <= OperationTypes.multiply;

        if (isInOperationsRange == false)
            throw new Exception("Operation is out of range!");

        return operationType;
    }
    public static void Proceed(out double result, in double first, in double second)
    {
        OperationTypes operationType = GetOperationTypeByUserInput();

        result = GetOperationResult(first, second, operationType, out char operationSymbol);
        //char operationSymbol = GetOperationSymbol(operationType);

        Console.WriteLine($"{first} {operationSymbol} {second} = {result}");
    }
    public static double TryGetInputedValue(string message)
    {
        bool parsed = false;
        double result = 0;
        while (parsed == false)
        {
            Console.Write($"{message}: ");
            parsed = double.TryParse(Console.ReadLine(), out result);
        }
        return result;
    }

    public static void Main()
    {
        //OperationTypes operationType = OperationTypes.plus;

        //// out
        //double num = 4;
        //ChangeValue(out double result, num, valueToChange: 2, operationType);

        //Console.WriteLine(result);



        // 1.у пользователя спрашивается: операция(+, -, /, *), первое и второе числа
        // 2.на экран пользователя выводится результат(result) операции(в Main методе)
        // 
        // void Proceed(out double result, in double first, in double second);

        double first = TryGetInputedValue("First number");
        double second = TryGetInputedValue("Second number");

        Proceed(out double result, first, second);

        //double first = 200;
        //double second = 600;
        //var result = GetOperationResult(first, second, OperationTypes.power, out char operationSymbol);
        //Console.WriteLine($"{first} {operationSymbol} {second} = {result}");
    }
}
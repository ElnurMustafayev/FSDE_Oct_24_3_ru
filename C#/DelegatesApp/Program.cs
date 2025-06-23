using DelegatesApp.Delegates;

if(false)
{
    void PrintHelloWorld()
    {
        Console.WriteLine("Hello World!");
    }

    void MyParameterlessMethod()
    {
        Console.WriteLine(nameof(MyParameterlessMethod));
    }

    MyParameterlessDelegate del = PrintHelloWorld;
    del += PrintHelloWorld;
    del += PrintHelloWorld;
    del += MyParameterlessMethod;

    del.Invoke();
    //del();
}

if(false)
{
    void MyParameterizedMethod(object obj)
    {
        Console.WriteLine(obj.ToString());
    }

    void ShowTypeMethod(object obj)
    {
        Console.WriteLine(obj.GetType().ToString());
    }

    MyParameterizedDelegate del = MyParameterizedMethod;
    del += ShowTypeMethod;

    del.Invoke(new Random().Next(100));
    del.Invoke("test".Length);
}

if(false)
{
    bool IsPositive(List<bool> results, int number)
    {
        var result = number > 0;
        results.Add(result);
        Console.WriteLine($"'{number}' is positive: {result}");
        return result;
    }

    bool IsNegative(List<bool> results, int number)
    {
        var result = number < 0;
        results.Add(result);
        Console.WriteLine($"'{number}' is negative: {result}");
        return result;
    }

    CheckNumberWithResultListDelegate del = IsPositive;
    del += IsNegative;
    del += IsNegative;

    var results = new List<bool>();

    var result = del.Invoke(results, 100);

    foreach (var item in results)
    {
        Console.WriteLine(item);
    }
}

if(false)
{
    const int EXCEPT_NUMBER = 5;
    void ShowNumbers(int[] nums, int exceptNumber = EXCEPT_NUMBER)
    {
        foreach (var num in nums)
        {
            bool show = (num % 2 == 1) && (num != exceptNumber);

            if (show)
            {
                Console.WriteLine(num);
            }
        }
    }

    void ShowNumbersWithPredicate(int[] nums, MyPredicate whenToShow, MyAction howToShow)
    {
        foreach (var num in nums)
        {
            if (whenToShow.Invoke(num))
            {
                howToShow.Invoke(num);
            }
        }
    }

    bool WhenToShowCondition(int num)
    {
        //if(num == EXCEPT_NUMBER)
        //{
        //    return false;
        //}
        if(num % 2 == 0)
        {
            return false;
        }

        return true;
    }

    void HowToShowNumber(int num)
    {
        Console.WriteLine($">>> > {num} < <<<");
    }

    int[] nums =
    {
        1,2,3,4,5,6,7,8,9
    };

    // нельзя показывать чётные числа и цифру 5
    //ShowNumbers(nums, 5);

    ShowNumbersWithPredicate(nums, WhenToShowCondition, HowToShowNumber);
}

if(false)
{
    MyAction<bool> action = new MyAction<bool>(delegate (bool check)
    {
        if(check == true)
            Console.WriteLine("1. LET'S GO");
    });

    action += delegate (bool check)
    {
        if (check == true)
            Console.WriteLine("2. LET'S GO");
    };

    // void MyAction(bool obj);
    // Lambda Expression
    action += (check) =>
    {
        if (check == true)
            Console.WriteLine("3. LET'S GO");
    };

    action.Invoke(true);
}

if(false)
{
    int GetSumOf(int[] nums, MyPredicate<int> condition)
    {
        int counter = 0;
        foreach(var num in nums)
        {
            if(condition.Invoke(num) == true)
            {
                counter++;
            }
        }

        return counter;
    }

    var result = GetSumOf(
        nums: [1, 2, 3, 5],
        condition: (num) => num % 2 == 1
        );

    Console.WriteLine(result);
}

if(true)
{
    Action action1 = () => Console.WriteLine("Hello World!");
    Action<string, double> action2 = (text, num) => Console.WriteLine($"{text}: '{num}'");

    Predicate<string> predicate1 = (str) => str.Length >= 10;
    Console.WriteLine(predicate1.Invoke("TEST"));

    Predicate<object> predicate2 = (obj) => obj is string;
    Console.WriteLine(predicate2.Invoke('A'));

    Func<int> func1 = () => 100;
    Func<int, string, decimal> func2 = (num, text) =>
    {
        if (num < 0)
        {
            return num;
        }
        else if (text.Length > 6)
        {
            return -num;
        }
        return num + text.Length;
    };

    Console.WriteLine(func2(12, "QWERTY").GetType());
}
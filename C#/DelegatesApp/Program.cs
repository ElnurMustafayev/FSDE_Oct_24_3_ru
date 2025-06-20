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

if(true)
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

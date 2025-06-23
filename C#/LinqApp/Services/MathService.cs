namespace LinqApp.Services;

static class MathService
{
    public static int Sum(IEnumerable<int> nums)
    {
        int result = default;

        foreach (var num in nums)
        {
            result += num;
        }

        //var enumerator = nums.GetEnumerator();
        //do
        //{
        //    int currentNum = enumerator.Current;
        //    result += currentNum;
        //} while (enumerator.MoveNext());
        //enumerator.Reset();

        return result;
    }

    public static T ElementAt<T>(IEnumerable<T> collection, int index) 
    {
        int currentIndex = 0;
        foreach (var currentItem in collection)
        {
            if (currentIndex == index)
                return currentItem;

            currentIndex++;
        }

        throw new Exception($"Item not found in collection by index '{index}'");
    }

    public static IEnumerable<T> Concat<T>(IEnumerable<T> collection1, IEnumerable<T> collection2)
    {
        List<T> resultArr = new List<T>();

        foreach (var item in collection1)
        {
            resultArr.Add(item);
        }

        foreach (var item in collection2)
        {
            resultArr.Add(item);
        }

        return resultArr;
    }
}
namespace LinqApp.Extensions;

static class EnumerableExtensions
{
    public static void Show<T>(
        this IEnumerable<T> collection, 
        Action<T> howToShow)
    {
        foreach (var item in collection)
        {
            howToShow.Invoke(item);
        }
    }
}
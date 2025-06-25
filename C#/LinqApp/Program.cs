using LinqApp.Models;
using LinqApp.Services;
using LinqApp.Extensions;

/*
// IEnumerable<int> nums1 = new List<int>();
// IEnumerable<int> nums2 = new int[] { 1 };

var student = new Student()
{
    //Marks = new List<int>() { 1, 2, 3 },
    Marks = new int[] { 1, 2, 3 },
};

foreach (var studentMark in student.Marks)
{
    Console.WriteLine(studentMark);
}
*/

//MathService.Sum(new List<int> { 1, 2, 3 });
//MathService.Sum(new int[] { 1, 2, 3 });

//var nums = new int[]
//{
//    1,22,333
//};

//int foundNum = MathService.ElementAt(nums, 1);
//Console.WriteLine(foundNum);

//IEnumerable<int> resultArray = MathService.Concat(new int[] { 1, 2, 3 }, new int[] { 11, 22, 33 });

//resultArray.Show((item) =>
//{
//    Console.BackgroundColor = ConsoleColor.DarkBlue;
//    Console.WriteLine(item);
//    Console.ResetColor();
//});

//foreach (var item in resultArray)
//{
//    Console.WriteLine(item);
//}


// int[] nums = new int[]
// {
//     1,2,3,4,5,6,7,8,9
// };

// int result1 = nums.Count(); // bad
// int result2 = nums.Length;  // good

// System.Console.WriteLine(result1);
// System.Console.WriteLine(result2);
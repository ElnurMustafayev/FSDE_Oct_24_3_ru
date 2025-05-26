/*
void ChangeString(string text)
{
    Console.WriteLine(text[1]);
    text[1] = 'a';
}
*/

/*
char[] chars = {
    'a', 'b', 'c'
};

chars[0] = 'w';

Console.WriteLine(chars);
*/



string text = "Hello World!";

//text.Clone();
//text.CompareTo("test");

//bool contains = text.Contains('?') || text.Contains('!');
//Console.WriteLine(contains);

//Console.WriteLine(text.StartsWith("H") && text.EndsWith("World!"));

//Console.WriteLine(text.IndexOf('l'));
//Console.WriteLine(text.LastIndexOf('l'));

//string textWithRigthPadding = text.PadRight(totalWidth: 20);
//string textWithLeftPadding = text.PadLeft(totalWidth: 20);

//Console.WriteLine($">{text}<");
//Console.WriteLine($">{textWithRigthPadding}<");
//Console.WriteLine($">{textWithLeftPadding}<");


//char symbol = 'l';
//int lastIndexOfSymbol = text.LastIndexOfAny(new char[] { char.ToLower(symbol), char.ToUpper(symbol) });
//string changedText = text.Remove(lastIndexOfSymbol);

//Console.WriteLine(changedText);



//text.Remove(lastIndexOfSymbol)
//    .ToLower()
//    .Trim()
//    .EndsWith("test");


//char symbol = 'l';
//string changedText = text.Replace(symbol, char.ToUpper(symbol));
//Console.WriteLine(changedText);



//string[] textParts = text.Split(' ');

//for (int i = 0; i < textParts.Length; i++)
//{
//    Console.WriteLine($"{i}: >{textParts[i]}<");
//}



//Console.WriteLine(text.Substring(6, 4));
//Console.WriteLine(text[6..10]);
//Console.WriteLine(text[6..]);
//Console.WriteLine(text[..10]);


//Console.WriteLine("bob2".ToUpper());
//Console.WriteLine("Bob".ToUpper());
//Console.WriteLine("BOB1".ToLower());
//Console.WriteLine("bob".ToLower());
//Console.WriteLine("bOb".ToLower());



string userInput = "    tEst ";
string normalizedUserInput = userInput.Trim().ToLower();

Console.WriteLine($">{userInput}<");
Console.WriteLine($">{normalizedUserInput}<");
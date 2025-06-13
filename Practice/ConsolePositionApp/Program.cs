const int enemyStartPositionY = 10;
const int enemyStartPositionX = 60;

void PrintArtInPosition(string art, int positionX = enemyStartPositionX, int positionY = enemyStartPositionY)
{
    string[] catAtrParts = art.Split('\n', StringSplitOptions.RemoveEmptyEntries);

    for (int i = 0; i < catAtrParts.Length; i++)
    {
        Console.SetCursorPosition(left: positionX, top: positionY + i);
        Console.WriteLine(catAtrParts[i]);
    }
}

string enemyCatAtr = @"
      |\__/,|   (`\
    _.|o o  |_   ) )
-(((---(((--------";

string myCatArt = @"
 _._     _,-'''''`-._
(,-.`._,'(       |\`-/|
    `-.-' \ )-`( , o o)
          `-    \`_`''''-";

int myCatCurrentPositionX = 0;

while(true)
{
    PrintArtInPosition(myCatArt, positionX: myCatCurrentPositionX, positionY: enemyStartPositionY);
    PrintArtInPosition(enemyCatAtr, positionX: enemyStartPositionX, positionY: enemyStartPositionY);

    //ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

    //if(consoleKeyInfo.Key == ConsoleKey.Escape)
    //{
    //    break;
    //}
    myCatCurrentPositionX++;
    Thread.Sleep(300);
    Console.Clear();
}
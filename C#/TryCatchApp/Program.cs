// validation rules:
// Name
//      Length: [2-50]
//      Only letters!
//      Space is not a symbol!
//          "   "   => false
//          " a "   => false
//          "ab"    => true
//          "a b"   => true
// Fin
//      Length: [7]
//      Only letters and digits!
//      Space is not a symbol!
//          " QWE TY1  "   => false
//          " QWE.TY1  "   => false
//          " QWERTY1  "   => true
//          "QWERTY1"   => true
void SetUserInfo()
{
    throw new StackOverflowException("TEST");
    const int nameMaxLength = 50;
    const int nameMinLength = 2;
    const int fincodeStandartLength = 7;

    Console.Write("Name: ");
    string name = Console.ReadLine();
    if(string.IsNullOrWhiteSpace(name))
    {
        throw new ArgumentException(message: "Name can not be empty!", paramName: nameof(name));
    }

    string normalizedName = name.Trim().ToLower();
    bool nameIsInRigthLength = nameMinLength <= normalizedName.Length && normalizedName.Length <= nameMaxLength;
    if (nameIsInRigthLength == false)
    {
        throw new ArgumentException(message: "2 <= Length <= 50", paramName: nameof(name));
    }

    for (int i = 0; i < normalizedName.Length; i++)
    {
        char currentSymbol = normalizedName[i];

        if (char.IsLetter(currentSymbol) == false)
        {
            throw new ArgumentException(message: "Name must contain only letters!", paramName: nameof(name));
        }
    }

    normalizedName = char.ToUpper(normalizedName[0]) + normalizedName[1..];




    Console.Write("FIN: ");
    string fincode = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(fincode))
    {
        throw new ArgumentException(message: "Fincode can not be empty!", paramName: nameof(fincode));
    }

    string normalizedFincode = fincode.Trim().ToUpper();

    if (normalizedFincode.Length != fincodeStandartLength)
    {
        throw new ArgumentException(message: "Length == 7", paramName: nameof(fincode));
    }

    for (int i = 0; i < normalizedFincode.Length; i++)
    {
        char currentSymbol = normalizedFincode[i];
        bool isNormalSymbol = char.IsLetter(currentSymbol) || char.IsDigit(currentSymbol);

        if (isNormalSymbol == false)
        {
            throw new ArgumentException(message: "Name must contain only letters or digits!", paramName: nameof(fincode));
        }
    }

    Console.Clear();
    Console.WriteLine("User info updated successfully!");

    Console.WriteLine($"Name: {normalizedName}");
    Console.WriteLine($"FIN: {normalizedFincode}");
}

try
{
    SetUserInfo();
}
catch (ArgumentException ex)
{
    Console.WriteLine($"{ex.ParamName}: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
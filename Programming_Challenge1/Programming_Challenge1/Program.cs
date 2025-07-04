string? userInput;

Console.WriteLine("Please input any word:");
userInput = Console.ReadLine();

userInput = UppercaseConverter(userInput!);
ArrayWritter(userInput);

Console.ReadKey();

static string UppercaseConverter (string input)
    {
        input = input.ToUpper();
        return input;
    }

static string ArrayWritter(string input)
{
    input.ToCharArray();

    foreach (char c in input)
    {
        Console.WriteLine(c);        
    }
    return null!;
}
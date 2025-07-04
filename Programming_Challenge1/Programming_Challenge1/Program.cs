using System.Linq;
using System.Text.RegularExpressions;

string? userInput;
string? inputUppercase;

Console.WriteLine("Please input any word:");
userInput = Console.ReadLine();


if (userInput != null)
{
    inputUppercase = VowelRemover(userInput).ToUpper();
    ArrayWritter(inputUppercase);
}
else
{
    Console.WriteLine("Input cannot be empty"); 
}


Console.ReadKey();

string VowelRemover (string input)
{
    string output = Regex.Replace(input, "[aeiouy]", "", RegexOptions.IgnoreCase);
    return output;
}
void ArrayWritter(string input)
{
    input.ToCharArray();
   
    foreach (char c in input)
    {

        Console.WriteLine(c);        
    }
}
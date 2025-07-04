using System.Linq;
using System.Text.RegularExpressions;

string? userInput;
string? inputUppercase;

Console.WriteLine("Please input any word:");
userInput = Console.ReadLine();


if (userInput != null)
{
    string output = Regex.Replace(userInput, "[aeiouy]", "", RegexOptions.IgnoreCase);
    inputUppercase = output.ToUpper();
    ArrayWritter(inputUppercase);
}
else
{
    Console.WriteLine("Input cannot be empty"); 
}


Console.ReadKey();


void ArrayWritter(string input)
{
    
    input.ToCharArray();
   
    foreach (char c in input)
    {

        Console.WriteLine(c);        
    }
}
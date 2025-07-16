using System.Text.RegularExpressions;

Random rnd = new Random();
bool finish = false;
do
{
    

    int numberOfThrows;
    string userInputThrows, userInputDice;

//testing
    bool isInt;
    bool isFloat;

    
Console.WriteLine("State amount of throws");
Console.WriteLine("Or end to finish");
userInputThrows= Console.ReadLine()!;

isInt = int.TryParse(userInputThrows, out numberOfThrows);

    if (isInt)
    {
        float dice;
        Console.WriteLine("State type of die:");
        userInputDice = Console.ReadLine()!;
        isFloat = float.TryParse(userInputDice, out dice);
        if (isFloat)
        {
            double sum=0;
            for (int i = 0; i < numberOfThrows; i++)
            { 
                double rndFloat = 1 + rnd.NextDouble() * (dice - 1);
                sum += rndFloat;
                Console.WriteLine($"Throw {i + 1}: {rndFloat:F2}");
            }
            Console.WriteLine($"Total: {sum:F2}");
        }
        else
        {
            Console.WriteLine("Wrong input. TryAgain.");
        }
    }
    else if (Regex.IsMatch(userInputThrows, "end", RegexOptions.IgnoreCase))
    {
        Console.WriteLine("Thank You for using the dice roller");
        finish = true;
    }
    else
    {
        Console.WriteLine("Wrong input. Try again.");
    }
}while(!finish);


Console.ReadKey();

//Napisz program, który działa w pętli (nie kończy się po pierwszym wykonaniu). Program powinien symulować rzuty kością do gry RPG. 
//    Użytkownik wpisuje rzut, który program ma wykonać w formie [ilość kości][k][rodzaj kości] 
//np. 2k6 oznacza 2 rzuty kością 6-ścienną. 4k12 oznacza 4 rzuty kością 12-ścienną.
//    Gdy użytkownik wpisze cokolwiek w niepasującym formacie program wypisuje error, ale nie przerywa działania. Gdy wpiszesz ‘koniec’ program przerywa się


Random rnd = new Random();
int dice;
int numberOfThrows;
string userInputThrows;


//testing
bool isInt;

Console.WriteLine("State amout of throws");
userInputThrows= Console.ReadLine();
Console.WriteLine(StringToIntConverter(userInputThrows));

int StringToIntConverter (string str)
{

    isInt = int.TryParse(userInputThrows, out numberOfThrows);

    try
    {
        return int.Parse(str);
    }
    catch
    {
        if (isInt == false)
        Console.WriteLine("The string couldn't get converted ");
        return 0;
    }
}










Console.ReadKey();

//Napisz program, który działa w pętli (nie kończy się po pierwszym wykonaniu). Program powinien symulować rzuty kością do gry RPG. 
//    Użytkownik wpisuje rzut, który program ma wykonać w formie [ilość kości][k][rodzaj kości] 
//np. 2k6 oznacza 2 rzuty kością 6-ścienną. 4k12 oznacza 4 rzuty kością 12-ścienną.
//    Gdy użytkownik wpisze cokolwiek w niepasującym formacie program wypisuje error, ale nie przerywa działania. Gdy wpiszesz ‘koniec’ program przerywa się


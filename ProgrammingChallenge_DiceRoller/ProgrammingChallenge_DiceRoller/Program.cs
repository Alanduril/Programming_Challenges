Random rnd = new Random();
float dice;
int numberOfThrows;
string userInputThrows;


//testing
bool isInt;


    Console.WriteLine("State amout of throws");
    userInputThrows = Console.ReadLine();

    isInt = int.TryParse(userInputThrows, out numberOfThrows);


    if (isInt)
    {
        Console.WriteLine("State type of die:");
    }
    else
    {
        Console.WriteLine("Wrong input. Terminating");
    }




Console.ReadKey();

//Napisz program, który działa w pętli (nie kończy się po pierwszym wykonaniu). Program powinien symulować rzuty kością do gry RPG. 
//    Użytkownik wpisuje rzut, który program ma wykonać w formie [ilość kości][k][rodzaj kości] 
//np. 2k6 oznacza 2 rzuty kością 6-ścienną. 4k12 oznacza 4 rzuty kością 12-ścienną.
//    Gdy użytkownik wpisze cokolwiek w niepasującym formacie program wypisuje error, ale nie przerywa działania. Gdy wpiszesz ‘koniec’ program przerywa się


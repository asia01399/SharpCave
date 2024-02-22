using System.ComponentModel;

Console.WriteLine("Zagrajmy w porównywanie liczb od 1 do 3");

string[] availableSigns = { "1", "2", "3" };
const string endGameCommand = "wyjdź";
int firstPlayerPoints = 0;
int secondPlayerPoints = 0;
int expectedRoundNumber = 3;

bool keepPlaying = true;

 while (keepPlaying)
 {
      for (int roundNumber = 1; roundNumber <= expectedRoundNumber; roundNumber++)
     {
     Console.WriteLine($" Runda {roundNumber}");

   string? firstPlayerSign;
   do
    {
    Console.WriteLine($"Podaj liczbę od 1 do 3 pierwszy graczu (lub wpisz'{endGameCommand}' by zamknąć grę):");
    firstPlayerSign = Console.ReadLine().ToLower();
    } while (!availableSigns.Contains(firstPlayerSign) && firstPlayerSign != endGameCommand);

       if (firstPlayerSign == endGameCommand)
        {
            keepPlaying = false;
            break;
        }

    string? secondPlayerSign;
    do
    {
    Console.WriteLine ($"Podaj liczbę od 1 do 3 drugi graczu (lub wpisz '{endGameCommand}' aby zakończyć grę):");
    secondPlayerSign = Console.ReadLine().ToLower();
    } 
    while (!availableSigns.Contains(secondPlayerSign) && secondPlayerSign != endGameCommand);

    if (secondPlayerSign == endGameCommand)
    {
        keepPlaying = false;
        break;
    }

    if(firstPlayerSign == secondPlayerSign)
    {
        Console.WriteLine("Remis!");
    }

    else if(firstPlayerSign == "3" && secondPlayerSign == "2")
    { 
        Console.WriteLine($"Pierwszy gracz wygrywa: {firstPlayerSign} bije {secondPlayerSign}!");
        firstPlayerPoints += 1;
    }
    else if(firstPlayerSign =="3" && secondPlayerSign == "1")
        { 
        Console.WriteLine($"Pierwszy gracz wygrywa: {firstPlayerSign} bije {secondPlayerSign}!");
        firstPlayerPoints += 1;
    }
    else if ( firstPlayerSign == "2" && secondPlayerSign == "1")
          { 
        Console.WriteLine($"Pierwszy gracz wygrywa: {firstPlayerSign} bije {secondPlayerSign}!");
        firstPlayerPoints += 1;
          }
    else if (secondPlayerSign == "3" && firstPlayerSign == "1")
    {
        Console.WriteLine($"Drugi gracz wygrywa: {secondPlayerSign} bije {firstPlayerSign}!");
        secondPlayerPoints += 1;
    }
else if (secondPlayerSign == "3" && secondPlayerSign == "2")
    {
        Console.WriteLine($"Drugi gracz wygrywa: {secondPlayerSign} bije {firstPlayerSign}!");
        secondPlayerPoints += 1;
    }
    else if (secondPlayerSign == "2" && secondPlayerSign == "1")
      {
        Console.WriteLine($"Drugi gracz wygrywa: {secondPlayerSign} bije {firstPlayerSign}!");
        secondPlayerPoints += 1;
    }
        Console.WriteLine($"Bieżący wynik: Gracz1: {firstPlayerPoints} Gracz2: {secondPlayerPoints}");
     }

    if (firstPlayerPoints > secondPlayerPoints)
    { 
        Console.WriteLine($"Gracz 1 wygrywa z graczem 2 z wynikiem: {firstPlayerPoints} do {secondPlayerPoints}!");
    }
    else if (secondPlayerPoints > firstPlayerPoints)
    {
        Console.WriteLine ($"Drugi gracz wygrywa z graczem 1 {secondPlayerPoints} do {firstPlayerPoints}!");
    }
    else
    {
       Console.WriteLine ($"Gra kończy się remisem {firstPlayerPoints} do {secondPlayerPoints}");
}

    firstPlayerPoints = 0;
    secondPlayerPoints = 0;
    }
Console.WriteLine("Wciśnij Enter aby zamknąć grę...");
Console.ReadLine();
   Console.WriteLine("Let's play Rock-Paper-Scissors!");
    // Type name;
    // Type veryLongName = value;
string[] availableSigns = {"rock", "paper", "scissors" };

 while(true)
 {
    // 1. First Player
    string? firstPlayerSign;
    do
    {
        Console.WriteLine("Provide sign, first player (or write 'quit' to end a game):");
        firstPlayerSign = Console.ReadLine();
    } while (!availableSigns.Contains(firstPlayerSign) && firstPlayerSign != "quit");
    
    // } while (firstPlayerSign !="rock" && firstPlayerSign !="paper"&& firstPlayerSign!="scissors" && firstPlayerSign != "quit");
    

       if (firstPlayerSign == "quit")
        {
            break;
        }

    //2. Second Player
    string? secondPlayerSign;
    do
    {
    Console.WriteLine ("Provide sign, second player (or write 'quit' to end a game):");
    secondPlayerSign = Console.ReadLine();
    } 
    while (secondPlayerSign !="rock" && secondPlayerSign !="paper" && secondPlayerSign !="scissors" && secondPlayerSign !="quit" );

    if (secondPlayerSign == "quit")
    {
        break;
    }

    int secondPlayerSignIndex = Array.IndexOf(availableSigns, secondPlayerSign);
    int winningWithSecondPlayerSignIndex = (secondPlayerSignIndex + 1) % availableSigns.Length;
    string winningWithSecondPlayerSign = availableSigns[winningWithSecondPlayerSignIndex];


    //3. Draw
    if(firstPlayerSign == secondPlayerSign)
    {
        Console.WriteLine("It,s a draw!");
    }

    else if(firstPlayerSign == winningWithSecondPlayerSign)
    { 
        Console.WriteLine("First Player won!");
    }
    
    else
    {
        Console.WriteLine("Second Player won!");
    }
    }

Console.WriteLine("Press Enter to close the game...");
Console.ReadLine();
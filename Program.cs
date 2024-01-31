// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Runtime.CompilerServices;

    Console.WriteLine("Let's play Rock-Paper-Scissors!");
 while(true)
 {
    // 1. First Player
    string? firstPlayerSign;
    do
    {
        Console.WriteLine("Provide sign, first player (or write 'quit' to end a game):");
        firstPlayerSign = Console.ReadLine();
    } while (firstPlayerSign !="rock" && firstPlayerSign !="paper"&& firstPlayerSign!="scissors" && firstPlayerSign != "quit");

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
    //3. Draw
    if(firstPlayerSign == secondPlayerSign)
    {
        Console.WriteLine("It,s a draw!");
    }

    else if((firstPlayerSign == "rock" && secondPlayerSign == "scissors" 
        || firstPlayerSign == "scissors" && secondPlayerSign == "paper" 
        ||firstPlayerSign == "paper" && secondPlayerSign == "rock"))
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
﻿// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Runtime.CompilerServices;

    Console.WriteLine("Let's play Rock-Paper-Scissors!");

    while(true)
    {
    Console.WriteLine("Provide sign, first player (or write 'quit' to end a game):");
    string? firstPlayerSign = Console.ReadLine();

    if (firstPlayerSign == "quit")
    {
        break;
    }

    Console.WriteLine ("Provide sign, second player (or write 'quit' to end a game):");
    string? secondPlayerSign = Console.ReadLine();
    if (secondPlayerSign == "quit")
    {
        break;
    }

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
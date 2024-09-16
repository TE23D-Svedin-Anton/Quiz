using System.ComponentModel;
using System.Drawing;

int Poäng = 0;
string val;

static int CheckaSvar(string correct)
{
    string val = Console.ReadLine();
    if (val.ToLower() == correct)
    {
        Console.WriteLine("");
        Console.WriteLine("RÄTT SVAR!");
        return 1;
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("FEL SVAR!");
        return 0;
    }
}

Console.WriteLine("Välkommen till min frågesport. Du kommer att få 3 kluriga frågor att svara på. Lycka till!");
Console.WriteLine("Tryck enter för att börja");
Console.ReadLine();

Console.WriteLine("Fråga nummer 1, Vad för moped är bäst?");
Console.WriteLine("A:Yamaha Aerox");
Console.WriteLine("B:Reiju Drac");
Console.WriteLine("C:Derbi Senda");


Poäng += CheckaSvar("a");

Console.WriteLine("Fråga nummer 2, Vad är 1 + 1?");
Console.WriteLine("A:11");
Console.WriteLine("B:2");
Console.WriteLine("C:3");

Poäng += CheckaSvar("b");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Fråga nummer 3, Vilken färg är texten");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("A:Röd");
Console.WriteLine("B:Blå");
Console.WriteLine("C:Grön");

 Poäng += CheckaSvar("c");

Console.WriteLine($"Du Hade {Poäng} Rätt");
Console.ReadLine();

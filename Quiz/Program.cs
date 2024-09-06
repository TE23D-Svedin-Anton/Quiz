int Poäng = 0;
string val;

Console.WriteLine("Välkommen till min frågesport. Du kommer få 3 kluriga frågor att svara på. Lycka till!");
Console.ReadLine();

Console.WriteLine("Fråga nummer 1,");
val = Console.ReadLine();
if (val.ToLower() == "")
{
    Poäng++;
    Console.WriteLine(Poäng);
}

Console.WriteLine("Fråga nummer 2,");
val = Console.ReadLine();
if (val.ToLower() == "")
{
    Poäng++;
    Console.WriteLine(Poäng);
}

Console.WriteLine("Fråga nummer 3,");
val = Console.ReadLine();
if (val.ToLower() == "")
{
    Poäng++;
    Console.WriteLine(Poäng);
}

Console.WriteLine("");
Console.ReadLine();

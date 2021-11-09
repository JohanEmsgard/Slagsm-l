using System;

Console.WriteLine("Mega charizard X vs Mega Charizard Y");
Console.ReadLine();

string name = "";
string attack = "";
while (name != "Mega Charizard X" && name != "Mega Charizard Y")
{
    Console.WriteLine("Chose your Figher, Mega Charizard X or Mega Charizard Y");
    name = Console.ReadLine();
}


int hpXform = 100;
int hpYform = 100;


while (hpXform > 0 && hpYform > 0)
{
    if (name == "Mega Charizard X")
    {
        Console.WriteLine("What Will Mega Charizard X do?");
        Console.WriteLine("Flamethrower");
        Console.WriteLine("Dragon Claw");
        Console.WriteLine("Thunder Punch");
        Console.WriteLine("Blast Burn");
        attack = Console.ReadLine();
    }

    if (attack == "Flamethrower")
    {
        Console.WriteLine("It's not very effective");
        attack = Console.ReadLine();
        hpYform -= 10;
    }

    else if (attack == "Thunder Punch")
    {
        Console.WriteLine("It's Super effective");
        attack = Console.ReadLine();
        hpYform -= 80;
    }

    else if (attack == "Dragon Claw")
    {
        Console.WriteLine();
        attack = Console.ReadLine();
        hpYform -= 40;
    }

    else if (attack == "Blast Burn")
    {
        Console.WriteLine("It's not very effective");
        attack = Console.ReadLine();
        hpYform -= 30;
        Console.WriteLine("Mega Charizard X must recharge");
    }

    if (hpYform <= 0)
    {
        Console.WriteLine("The Oppesing Mega Charizard Y fainted");
    }

    else if (hpXform <= 0)
    {
        Console.WriteLine("Mega Charizard X fainted");
    }

    else if (name == "Mega Charizard Y")
    {
        Console.WriteLine("What Will Mega Charizard Y do?");
        Console.WriteLine("Fire Spin");
        Console.WriteLine("Dragon Claw");
        Console.WriteLine("Heat Wave");
        Console.WriteLine("Dragon Tail");
        attack = Console.ReadLine();
    }

    if (attack == "Fire Spin")
    {
        Console.WriteLine("It's not very effective");
        attack = Console.ReadLine();
        hpXform -= 10;
    }

    else if (attack == "Dragon Claw")
    {
        Console.WriteLine("It's Super effective");
        attack = Console.ReadLine();
        hpXform -= 50;
    }

    else if (attack == "Heat Wave")
    {
        Console.WriteLine("It's not very effective");
        attack = Console.ReadLine();
        hpXform -= 30;
    }

    else if (attack == "Dragon Tail")
    {
        Console.WriteLine("It's super effective");
        attack = Console.ReadLine();
        hpXform -= 45;
    }

    Console.ReadLine();
}

if (hpYform <= 0)
{
    Console.WriteLine("Mega Charizard X Wins");
}

else
{
    Console.WriteLine("Mega Charizard Y Wins");
}

Console.ReadLine();

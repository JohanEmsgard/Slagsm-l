﻿using System;

Console.WriteLine("Mega charizard X vs Mega Charizard Y");
Console.ReadLine();

string name = "";
string attack = "";
while (name != "X" && name != "Y")
{
    Console.WriteLine("Chose your Figher, Mega Charizard X or Mega Charizard Y");
    name = Console.ReadLine();
}


int hpXform = 100;
int hpYform = 100;


while (hpXform > 0 && hpYform > 0)
{
    if (name == "X")
    {
        Console.WriteLine("What Will Mega Charizard X do?");
        Console.WriteLine("1) Flamethrower");
        Console.WriteLine("2) Dragon Claw");
        Console.WriteLine("3) Thunder Punch");
        Console.WriteLine("4) Blast Burn");
        attack = Console.ReadLine();
    }

    if (attack == "1")
    {
        Console.WriteLine("It's not very effective");
        attack = Console.ReadLine();
        hpYform -= 10;
    }

    else if (attack == "3")
    {
        Console.WriteLine("It's Super effective");
        attack = Console.ReadLine();
        hpYform -= 80;
    }

    else if (attack == "2")
    {
        Console.WriteLine();
        attack = Console.ReadLine();
        hpYform -= 40;
    }

    else if (attack == "4")
    {
        Console.WriteLine("It's not very effective");
        attack = Console.ReadLine();
        hpYform -= 30;
        Console.WriteLine("Mega Charizard X must recharge");
    }

    

    else if (name == "Y")
    {
        Console.WriteLine("What Will Mega Charizard Y do?");
        Console.WriteLine("1) Fire Spin");
        Console.WriteLine("2) Dragon Claw");
        Console.WriteLine("3) Heat Wave");
        Console.WriteLine("4) Dragon Tail");
        attack = Console.ReadLine();
    }

    if (attack == "1")
    {
        Console.WriteLine("It's not very effective");
        attack = Console.ReadLine();
        hpXform -= 10;
        Console.WriteLine("The Oppessing Mega Charizard X was trapped in a Vortex");
    }

    else if (attack == "2")
    {
        Console.WriteLine("It's Super effective");
        attack = Console.ReadLine();
        hpXform -= 50;
    }

    else if (attack == "3")
    {
        Console.WriteLine("It's not very effective");
        attack = Console.ReadLine();
        hpXform -= 30;
    }

    else if (attack == "4")
    {
        Console.WriteLine("It's super effective");
        attack = Console.ReadLine();
        hpXform -= 45;
    }

    Console.ReadLine();
}


if (hpYform <= 0)
{
    Console.WriteLine("Mega Charizard Y Fainted");
    Console.ReadLine();
    Console.WriteLine("Mega Charizard X Wins");
}

else
{
    Console.WriteLine("Mega Charizard X Fainted");
    Console.ReadLine();
    Console.WriteLine("Mega Charizard Y Wins");
}


Console.ReadLine();

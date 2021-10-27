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
if ( attack == "flamethrower")
{
    Console.WriteLine("It's not very effective"); 
    attack = Console.ReadLine();
    hpYform -= 10; 
}

else
{
    Console.WriteLine("What Will Mega Charizard Y do?");
    Console.WriteLine("Fire Spin");
    Console.WriteLine("Dragon Claw");
    Console.WriteLine("Heat Wave");
    Console.WriteLine("Dragon Tail");
}


Console.ReadLine(); 
}


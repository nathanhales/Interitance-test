
using System.Security.Cryptography.X509Certificates;

Bat bat = new Bat();
Console.WriteLine($"Name: {bat.Name} Health: {bat.Health} Armor Value: {bat.Armor}\n");
bat.BatScreech();

Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------\n");

Knight knight = new Knight();
Console.WriteLine($"\nName: {knight.Name} Health: {knight.Health} Armor Value: {knight.Armor} Weapon: {knight.Weapon}\n");
knight.KnightIntro();


class Enemy
{
    private int _health;
    private string _name;
    private int _armorValue;
    private int _manaValue;

    public int Health
    {
        get { return _health; }
        set { _health = value; }
    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public int Armor
    {
        get { return _armorValue; }
        set { _armorValue = value; }
    }
    public int ManaValue
    {
        get { return _manaValue; }
        set { _manaValue = value; }
    }

    public void Flying(bool canFly)
    {
        if (canFly == true)
        {
            Console.WriteLine("CAUTION - This enemy is flying\n");
        }
    }
}

class Bat : Enemy
{   
    public void BatScreech()
    {
        Console.WriteLine("\nEEEEEEEEEEEEEEEEEEEEEEEEEEEE\n");
    }
    public Bat()
    {
        Name = "bat";
        Health = 150;
        Armor = 10;
        Flying(true);
    }
}

class Knight : Enemy
{
    private Weapons _weapon;

    public Weapons Weapon
    {
        get { return _weapon; }
        set { _weapon = value; }
    }

    public Knight()
    {
        Name = "Knight";
        Health = 500;
        Armor = 250;
        Weapon = Weapons.Sword;
        Flying(false);
    }

    public void KnightIntro()
    {
        Console.WriteLine("Prepare to die!");
    }
}

enum Weapons { Sword, Spear, Flail, Halberd }
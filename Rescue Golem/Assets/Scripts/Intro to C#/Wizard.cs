using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : Player // inheriting from Player class
{
    public static int power = 100; // a static variable, so called a "class variable"

    public Wizard()
    {

    }

    public Wizard(string name, float health)
    {
        this.Name = name;
        this.Health = health;
    }

    public override void Attack()
    {
        Debug.Log("Wizard is casting a fireball!");
    }
}
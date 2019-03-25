using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : Player // inheriting from Player class
{
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : Player // inheriting from Player class
{
    public static int power = 100; // a static variable, so called a "class variable"
    public delegate void PlayerDied();
    public static event PlayerDied playerDied; // this is our "letter"

    void Start()
    {
        StartCoroutine(CallFunction());
    }

    IEnumerator CallFunction()
    {
        // "ok, does anybody have that letter?" -> simply checks if anybody have our event ("letter")
        yield return new WaitForSeconds(2f);
        if(playerDied != null)
        {
            playerDied(); // "ok, deliver it now"
        }
    }

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
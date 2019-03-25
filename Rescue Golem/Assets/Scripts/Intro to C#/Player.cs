using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float health = 100f;
    private string name = "Wizard";

    // constructor
    public Player()
    {

    }

    public Player(string namePlayer, float health)
    {
        // "this" keyword referring to the class where it is called
        this.name = namePlayer; // referring to the string name at top of the class and equal to the parameter string
        this.health = health; // referring to the float health at top of the class and equal to the parameter float
    }

    // allow to manipulate private variable outside this class
    // "setter"
    public void SetHealth(float health)
    {
        this.health = health;
    }

    // "getter"
    public float GetHealth()
    {
        return this.health;
    }

    // another getter/setter example
    public float Health
    {
        get
        {
            return health;
        }

        set
        {
            health = value;
        }
    }

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

    public virtual void Attack()
    {
        Debug.Log("Player is attacking");
    }

    public void PlayerInfo()
    {
        Debug.Log("Player name is " + name + " and player's health is " + health);
    }
}
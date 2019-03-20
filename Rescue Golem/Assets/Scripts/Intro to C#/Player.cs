using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public float health = 100f;
    public string name = "Wizard";

    public void PlayerInfo()
    {
        Debug.Log("Player name is " + name + " and player's health is " + health);
    }
}

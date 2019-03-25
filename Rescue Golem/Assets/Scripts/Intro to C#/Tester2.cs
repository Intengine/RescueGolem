using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester2 : MonoBehaviour
{
    Player wizard = new Player(); // creating object of Player class
    Player monk = new Player("Monk", 12.7f); // this is the constructor from Player class

    private Wizard necromant;

    int[] data;

    void Start()
    {
        data = ProcessArrays(data);
        for (int i = 0; i < data.Length; i++)
        {
            print("The value is " + data[i]);
        }
        wizard.PlayerInfo();

        wizard.Name = "Knight";
        wizard.SetHealth(44f);
        print(wizard.GetHealth());

        wizard.PlayerInfo();
        monk.PlayerInfo();

        ChangePlayer(monk); // passing as a reference
        monk.PlayerInfo();

        Wizard w = new Wizard("Gandalf", 33.7f); // wizard from Wizard class

        w.PlayerInfo();
        w.Attack(); // overrided function

        // using GameObject class (from MonoBehaviour) and its Find function passing the name of the game object that we want to find
        // that function finding it at the Hierarchy panel in Unity and return (by GetComponent) Wizard generic component
        necromant = GameObject.Find("Player").GetComponent<Wizard>();
    }

    int[] ProcessArrays(int[] data)
    {
        data = new int[10];
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = Random.Range(0, 100);
        }
        return data;
    }

    void ProcessArray(int[] data)
    {
        for(int i = 0; i < data.Length; i++)
        {
            data[i] = Random.Range(0, 100);
            print("The value is " + data[i]);
        }
    }

    // passing values and references to function parameters
    void ChangePlayer(Player enemy)
    {
        enemy.Name = "Vargas";
    }
}
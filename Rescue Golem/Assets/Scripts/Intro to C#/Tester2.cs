using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester2 : MonoBehaviour
{
    Player wizard = new Player(); // creating object of Player class

    int[] data;

    void Start()
    {
        data = ProcessArrays(data);
        for (int i = 0; i < data.Length; i++)
        {
            print("The value is " + data[i]);
        }
        wizard.PlayerInfo();

        wizard.name = "Knight";
        wizard.health = 44f;

        wizard.PlayerInfo();
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
}
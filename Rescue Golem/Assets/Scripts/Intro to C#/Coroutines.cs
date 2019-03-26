using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    void Start()
    {
        PrintNow();
        StartCoroutine(PrintAfterDelay(3f)); // that's how we are calling coroutines
    }

    void PrintNow()
    {
        print("Printed now...");
    }

    IEnumerator PrintAfterDelay(float time)
    {
        yield return new WaitForSeconds(time); // coroutine
        print("Printed after some seconds...");
    }
}
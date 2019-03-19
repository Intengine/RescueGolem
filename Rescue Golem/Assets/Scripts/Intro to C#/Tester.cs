using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    void Start()
    {
        CalculateTwoNumbers(4, 8);
        print("The second calculation is " + SecondCalculation());
        print("The third calculation is " + ThirdCalculation(88, 223));
    }

    void Update()
    {
        
    }

    void CalculateTwoNumbers(int a, int b)
    {
        print("The sum of two numbers is " + (a + b));
    }

    int SecondCalculation()
    {
        return 5 + 6;
    }

    int ThirdCalculation(int a, int b)
    {
        return a + b;
    }
}
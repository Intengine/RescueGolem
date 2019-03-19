using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    // whole code shouldn't be in that function, but this is for the practice
    void Start()
    {
        CalculateTwoNumbers(4, 8);
        print("The second calculation is " + SecondCalculation());
        print("The third calculation is " + ThirdCalculation(88, 223));

        int a = 9;
        int b = 6;
        int c = 3;

        if(a <= b)
        {
            print("A is lower than B or it is equal to B");
        } else if(a == b)
        {
            print("A is equal to B");
        } else if(a >= b)
        {
            print("A is greater than B or it is equal to B");
        }
        else
        {
            print("Default statement");
        }

        if(b < a && a > c) // AND
        {
            print("This is true");
        }

        if (b < a || a > c) // OR
        {
            print("This is also true");
        }

        switch (a) // another type of conditional statement
        {
            case 1:
                break;
            case 5:
                break;
            case 9:
                print("A is equal to 9");
                break;
            default:
                print("Default statement");
                break;
        }

        // for loop
        for(int i=0; i < 10; i++) // for "i" which is currently = 0, as long as "i" < 10, execute the code and increment "i"
        {
            print("The value of i is" + i);
        }

        // while loop
        int j = 0;

        while(j < 10)
        {
            print(j);
            j++;
        }

        // do while loop
        int k = 0;

        do
        {
            print("The last number is " + k);
            k++;
        } while (k < 10);

        // arrays
        int[] data = new int[10];
        for (int z = 0; z < data.Length; z++)
        {
            data[z] = Random.Range(0, 100);
            print("The element at index " + z + " has a value of " + data[z]);
        }

        // foreach loop
        foreach(int num in data)
        {
            print("The value of the element is " + num);
        }
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
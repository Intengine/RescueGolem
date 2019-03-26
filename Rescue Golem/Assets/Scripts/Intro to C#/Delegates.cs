using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// delegate is like a letter that we need to deliver to somebody but we don't care who wants to deliver that letter
// event from that deliver is the letter and we want somebody to deliver that letter to point "X"

public class Delegates : MonoBehaviour
{
    // first function that is going to call
    void Awake()
    {

    }

    // third function that is going to call
    void Start()
    {
        
    }

    // second function that is going to call
    void OnEnable()
    {
        Wizard.playerDied += ExecutedAfterEventCall; // it is subscribing to the PlayerDied event ("ok, I've got that letter, I will deliver it") -> in that case, the letter is delivering by Delegates class
    }

    // that function is called after quit the game
    void OnDisable()
    {
        Wizard.playerDied -= ExecutedAfterEventCall; // it is unsubscribing to the PlayerDied event
    }

    void ExecutedAfterEventCall()
    {
        print("Printed after call was executed");
    }
}
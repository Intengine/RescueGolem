﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour
{
    public enum GameState
    {
        Started,
        Paused,
        Ended,
        PlayerDied,
        MainMenu
    }

    GameState gameState = GameState.MainMenu;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
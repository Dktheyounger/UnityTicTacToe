﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneController : MonoBehaviour
{
    //Scene Controlling Script

    public void StartScene()
    {
        //reset all variables and change scene to the start scene

        try
        {
            SceneManager.LoadScene("Start");
        }
        catch (Exception e)
        {
            Debug.Log("Check if scene exists");
            Debug.Log(e);
        }

        WinnerChecker.winner = 0;
        WinnerChecker.gameOver = false;
        WinnerChecker.letterTracker[0, 0] = 0;
        WinnerChecker.letterTracker[1, 0] = 0;
        WinnerChecker.letterTracker[2, 0] = 0;

        WinnerChecker.letterTracker[0, 1] = 0;
        WinnerChecker.letterTracker[1, 1] = 0;
        WinnerChecker.letterTracker[2, 1] = 0;

        WinnerChecker.letterTracker[0, 2] = 0;
        WinnerChecker.letterTracker[1, 2] = 0;
        WinnerChecker.letterTracker[2, 2] = 0;

        
    }
    public void GameScene()
    {
        //Change scene to game scene
        try 
        {
            SceneManager.LoadScene("Game");
        }
        catch(Exception e)
        {
            Debug.Log("Check if scene exists");
            Debug.Log(e);
        }
    }

}

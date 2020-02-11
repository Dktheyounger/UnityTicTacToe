using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerScreen : MonoBehaviour
{
    //The panel for when O wins
    public GameObject OWinsPanel;

    //The panel for when X wins
    public GameObject XWinsPanel;

    private void Update()
    {
        //Starts panels depending on winner 1 is for O 2 is for X
        if (WinnerChecker.gameOver == true && WinnerChecker.winner == 1)
        {
            OWinsPanel.SetActive(true);
        }
        else if (WinnerChecker.gameOver == true && WinnerChecker.winner == 2)
        {
            XWinsPanel.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerChecker : MonoBehaviour
{
    // A multi dimensional array for to represent each square of the game board
    public static int[,] letterTracker = new int[3, 3];

    //Used to tell when the game is over
    public static bool gameOver = false;

    //1 is O 2 is X
    public static int winner = 0;

    //Each of these are used to tell a indevidual square wether it becomes a 1 or a 2 (O or X)
    //2 and 1 are switch because this happens after they switch in square script
    public void SquareOneOne()
    {
        if (TurnSelctor.First == true && letterTracker[0, 0] == 0)
        {
            letterTracker[0, 0] = 2;
        }
        else if (TurnSelctor.First == false && letterTracker[0, 0] == 0)
        {
            letterTracker[0, 0] = 1;
        }
       
    }
    public void SquareTwoOne()
    {
        if (TurnSelctor.First == true && letterTracker[1, 0] == 0)
        {
            letterTracker[1, 0] = 2;
        }
        else if (TurnSelctor.First == false && letterTracker[1, 0] == 0)
        {
            letterTracker[1, 0] = 1;
        }
    }
    public void SquareThreeOne()
    {
        if (TurnSelctor.First == true && letterTracker[2, 0] == 0)
        {
            letterTracker[2, 0] = 2;
        }
        else if (TurnSelctor.First == false && letterTracker[2, 0] == 0)
        {
            letterTracker[2, 0] = 1;
        }
    }
    public void SquareOneTwo()
    {
        if (TurnSelctor.First == true && letterTracker[0, 1] == 0)
        {
            letterTracker[0, 1] = 2;
        }
        else if (TurnSelctor.First == false && letterTracker[0, 1] == 0)
        {
            letterTracker[0, 1] = 1;
        }
    }
    public void SquareTwoTwo()
    {
        if (TurnSelctor.First == true && letterTracker[1,1] == 0)
        {
            letterTracker[1, 1] = 2;
        }
        else if(TurnSelctor.First == false && letterTracker[1, 1] == 0)
        {
            letterTracker[1, 1] = 1;
        }
    }
    public void SquareThreeTwo()
    {
        if (TurnSelctor.First == true && letterTracker[1, 2] == 0)
        {
            letterTracker[1, 2] = 2;
        }
        else if (TurnSelctor.First == false && letterTracker[1, 2] == 0)
        {
            letterTracker[1, 2] = 1;
        }
    }
    public void SquareOneThree()
    {
        if (TurnSelctor.First == true && letterTracker[0, 2] == 0)
            {
            letterTracker[0, 2] = 2;
        }
        else if (TurnSelctor.First == false && letterTracker[0, 2] == 0)
        {
            letterTracker[0, 2] = 1;
        }
    }
    public void SquareTwoThree()
    {
        if (TurnSelctor.First == true && letterTracker[2, 1] == 0)
        {
            letterTracker[2, 1] = 2;
        }
        else if (TurnSelctor.First == false && letterTracker[2, 1] == 0)
        {
            letterTracker[2, 1] = 1;
        }
    }
    public void SquareThreeThree()
    {
        if (TurnSelctor.First == true && letterTracker[2, 2] == 0)
        {
            letterTracker[2, 2] = 2;
        }
        else if (TurnSelctor.First == false && letterTracker[2, 2] == 0)
        {
            letterTracker[2, 2] = 1;
        }
    }

    //Constantly checks to see if some one won
    void Update()
    {
        CheckIfPlayerOneWins();
        CheckIfPlayerTwoWins();
    }

    //A bunch of if statements that check if some one has achieve a three in a row 1 for O 2 for X
    public void CheckIfPlayerOneWins()
    {
        if (letterTracker[0, 0] == Square.playerOne && letterTracker[0, 1] == Square.playerOne && letterTracker[0, 2] == Square.playerOne) { gameOver = true; winner = 1; }
        if (letterTracker[1, 0] == Square.playerOne && letterTracker[1, 1] == Square.playerOne && letterTracker[1, 2] == Square.playerOne) { gameOver = true; winner = 1; }
        if (letterTracker[2, 0] == Square.playerOne && letterTracker[2, 1] == Square.playerOne && letterTracker[2, 2] == Square.playerOne) { gameOver = true; winner = 1; }

        if (letterTracker[0, 0] == Square.playerOne && letterTracker[1, 0] == Square.playerOne && letterTracker[2, 0] == Square.playerOne) { gameOver = true; winner = 1; }
        if (letterTracker[0, 1] == Square.playerOne && letterTracker[1, 1] == Square.playerOne && letterTracker[2, 1] == Square.playerOne) { gameOver = true; winner = 1; }
        if (letterTracker[0, 2] == Square.playerOne && letterTracker[1, 2] == Square.playerOne && letterTracker[2, 2] == Square.playerOne) { gameOver = true; winner = 1; }

        if (letterTracker[0, 0] == Square.playerOne && letterTracker[1, 1] == Square.playerOne && letterTracker[2, 2] == Square.playerOne) { gameOver = true; winner = 1; }
        if (letterTracker[2, 0] == Square.playerOne && letterTracker[1, 1] == Square.playerOne && letterTracker[0, 2] == Square.playerOne) { gameOver = true; winner = 1; }
    }
    public void CheckIfPlayerTwoWins()
    {
        if (letterTracker[0, 0] == Square.playerTwo && letterTracker[0, 1] == Square.playerTwo && letterTracker[0, 2] == Square.playerTwo) { gameOver = true; winner = 2; }
        if (letterTracker[1, 0] == Square.playerTwo && letterTracker[1, 1] == Square.playerTwo && letterTracker[1, 2] == Square.playerTwo) { gameOver = true; winner = 2; }
        if (letterTracker[2, 0] == Square.playerTwo && letterTracker[2, 1] == Square.playerTwo && letterTracker[2, 2] == Square.playerTwo) { gameOver = true; winner = 2; }

        if (letterTracker[0, 0] == Square.playerTwo && letterTracker[1, 0] == Square.playerTwo && letterTracker[2, 0] == Square.playerTwo) { gameOver = true; winner = 2; }
        if (letterTracker[0, 1] == Square.playerTwo && letterTracker[1, 1] == Square.playerTwo && letterTracker[2, 1] == Square.playerTwo) { gameOver = true; winner = 2; }
        if (letterTracker[0, 2] == Square.playerTwo && letterTracker[1, 2] == Square.playerTwo && letterTracker[2, 2] == Square.playerTwo) { gameOver = true; winner = 2; }

        if (letterTracker[0, 0] == Square.playerTwo && letterTracker[1, 1] == Square.playerTwo && letterTracker[2, 2] == Square.playerTwo) { gameOver = true; winner = 2; }
        if (letterTracker[2, 0] == Square.playerTwo && letterTracker[1, 1] == Square.playerTwo && letterTracker[0, 2] == Square.playerTwo) { gameOver = true; winner = 2; }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Square : MonoBehaviour
{
    //O image
    public Sprite OSprite;
    
    //X image
    public Sprite XSprite;

    //Individual button
    public Button button;

    //Used to control opacity of buttons so you can see them when transformed to X or O
    public Image image;

    // 1 is for O 2 is for X
    public static int playerOne = 1;
    public static int playerTwo = 2;


    //used to lock each indevidual square into either 1 or 2 for O or X
    private int NoneorOorX = 0;


    //When button is pressed opacity changed image changed turn changed and locked into 1 or 2 for O or X
    public void ButtonPressed()
    {
        if (TurnSelctor.First == true && NoneorOorX == 0)
        {
            try
            {
                image = GetComponent<Image>();
                image.color = new Color(image.color.r, image.color.g, image.color.b, 255f);
            }
            catch (Exception e)
            {
                Debug.Log(e);
                Debug.Log("Check if Image exists");
            }


            try
            {
                button.image.sprite = OSprite;
            }
            catch (Exception e)
            {
                Debug.Log(e);
                Debug.Log("button exists");
            }
            
            TurnSelctor.First = false;
            NoneorOorX = 1;
            
            
           
           
            
        }
        else if (TurnSelctor.First == false && NoneorOorX == 0)
        {
            try
            {
                image = GetComponent<Image>();
                image.color = new Color(image.color.r, image.color.g, image.color.b, 255f);
            }
            catch (Exception e)
            {
                Debug.Log(e);
                Debug.Log("Check if Image exists");
            }

            try
            {
                button.image.sprite = XSprite;
            }
            catch (Exception e)
            {
                Debug.Log(e);
                Debug.Log("button exists");
            }
            

            TurnSelctor.First = true;
            NoneorOorX = 2;
            

           



        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFunctionality : MonoBehaviour
{   
    public GameManager gameManager;

    [SerializeField]
    public int quantity;

    public void Start()
    {
    }

    public void ButtonPress(int points)
    {
        if (gameManager.Buttons.Contains<ButtonFunctionality>(this))//checks the array for this Object
        {
            gameManager.Points += calcpoints(points, quantity);//adds the calculated result to the game manager
            gameManager.text.text = "Points:" + gameManager.Points.ToString();//sets the text to be correct with the points value in the game manager
        }
    }

    public int calcpoints(int points, int quant)//A simple calculation for point collection and multipliers
    {
        return points * quant;
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFunctionality : MonoBehaviour
{

    public int quantity;
    public Text text;
    public GameManager gameManager;

    public void Start()
    {
    }

    public void ButtonPress(int points)
    {
        gameManager.Points += points;
        text.text = "Points:" + gameManager.Points.ToString();
       
    }



}

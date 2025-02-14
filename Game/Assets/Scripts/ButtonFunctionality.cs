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
        if (gameManager.Buttons.Contains<ButtonFunctionality>(this))
        {
            gameManager.Points += calcpoints(points, quantity);
            gameManager.text.text = "Points:" + gameManager.Points.ToString();
        }
    }

    public int calcpoints(int points, int quant)
    {
        return points * quant;
    }
}

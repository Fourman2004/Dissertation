# Artefact

##

### ButtonFunctionality.cs
#### Scrapped
``cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFunctionality : MonoBehaviour
{
    private readonly IEnumerator Coroutine;

    public int points,quantity;

    bool Manager;
   
    void ButtonPress()
    {
        if (!Manager)
        {
            points += points * quantity;
        }
        else
        {
            StartCoroutine(Coroutine);
        }
    }

}``
#### Old
``cs
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



}``

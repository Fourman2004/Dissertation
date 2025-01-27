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

    

}

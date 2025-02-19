using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class UpgradeButton : MonoBehaviour
{

    [SerializeField]
    public float threshold;

    public GameManager gameManager;

    public ButtonFunctionality buttonToUpgrade;

    [SerializeField]
    float Mult;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void quantUpdate()
    {
        if (gameManager.Points >= threshold)
        {
            buttonToUpgrade.quantity++;
            gameManager.Points -= (int)threshold;
            gameManager.text.text = "Points:" + gameManager.Points.ToString();
            threshold += (int)Mathf.Pow(threshold, Mult);
            Debug.Log("New Threshold:" + threshold);
        }
        else
        {
            Debug.LogWarning("Cannot upgrade");
        }

    }
}

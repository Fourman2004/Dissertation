using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int Points;

    public ButtonFunctionality[] Buttons;

    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        text.text = "Points:" + Points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

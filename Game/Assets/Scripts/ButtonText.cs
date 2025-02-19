using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonText : MonoBehaviour
{

    public string text;
    [SerializeField]
    Text buttontext;

    public ButtonFunctionality button1;
    public UpgradeButton Button2;

    public bool Upgrade;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        switch (Upgrade)
        {
            case (true):
                buttontext.text = text + Button2.threshold + ")";
                break;
            case (false):
                buttontext.text = text + button1.quantity + ")";
                break;
        }
    }
}

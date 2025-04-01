# Artefact

##

### ButtonFunctionality.cs
#### Scrapped
```cs
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

}```


#### Old
```cs
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



}```

#### New
```cs
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFunctionality : MonoBehaviour
{   
    public GameManager gameManager;

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

```

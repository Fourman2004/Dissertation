using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;



public class GameManager : MonoBehaviour
{
    public int Points;

    public ButtonFunctionality[] Buttons;

    public Text text;

    int counter;

    // Start is called before the first frame update
    void Start()
    {
        text.text = "Points:" + Points.ToString();//initalizes text at the top of the page
        PlayerPrefs.GetInt("PlayerID", counter++); 
    }

   public void CollectData()
   {
        string filePath = Application.dataPath + "/Data.csv";
        StreamWriter writer = new StreamWriter(filePath);
        writer.WriteLine("ID,ActualTime,Time");
        writer.WriteLine(" ," + Time.time + ", ");
        writer.Close();
        Debug.Log("Saved at" + filePath);
    }
}

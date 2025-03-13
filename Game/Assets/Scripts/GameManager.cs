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

    public bool Testbool;

    // Start is called before the first frame update
    void Start()
    {
        text.text = "Points:" + Points.ToString();//initalizes text at the top of the page
    }

    
    // CollectData() functionality was created with the assistance of Ai (CoPilot).
    public void CollectData(bool dataSuccess)
   {
        string filePath = Application.dataPath + "/Data.csv";//Creates File 
        using StreamWriter writer = new(filePath, true);// creates a new data streamwriter with the ability to append
        {
            if (!File.Exists(filePath)) {writer.WriteLine("ID,ActualTime,Time"); }//Writes the headers first if the file doesn't exist
            writer.WriteLine(" ," + (int)Time.time + ", ");//Writes the data
        }
        writer.Close();//Shuts down the writer, until it needs to write again
        dataSuccess = true;
        Testbool = dataSuccess;
        Debug.Log("Saved at" + filePath);//shows where it is in editor
    }
}

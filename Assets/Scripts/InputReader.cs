using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class InputReader : MonoBehaviour
{

    public string line;
    public int lineSize;

    public Button button0;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;

    public Button minus;
    public Button plus;
    public Button divide;
    public Button mult;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("InputReader is running");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void name1()
    {
        Debug.Log("Button pressed");
    }

    public void SendInput(string testing)
    {
        //Debug.Log("Pressed " + testing);
        if(line.Length < lineSize)
        {
            line += testing;
        }
        Debug.Log(line);
    }

    public void DeleteButton()
    {
        line = line.Substring(0, line.Length - 1);
        Debug.Log(line);
    }
}

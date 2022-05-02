using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

public class InputReader : MonoBehaviour
{

    public string line;
    public int lineSize;
    public TMP_Text demo;

    public CompareEqs compare;



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
        demo.text = line;
    }

    public void DeleteButton()
    {
        line = line.Substring(0, line.Length - 1);
        Debug.Log(line);
        demo.text = line;
    }

    public void SendAnswer()
    {
        compare.attempt = line;
        compare.CheckAnswer();
    }
}

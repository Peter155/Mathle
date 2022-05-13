using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayAnswers : MonoBehaviour
{

    public string[,] numbers;

    public TMP_Text row1;
    public TMP_Text row2;
    public TMP_Text row3;

    public TMP_Text column1;
    public TMP_Text column2;
    public TMP_Text column3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setNumbers(string[,] numbers)
    {
        this.numbers = numbers;

        row1.text = numbers[0, 5];
        row2.text = numbers[2, 5];
        row3.text = numbers[4, 5];

        column1.text = numbers[5, 0];
        column2.text = numbers[5, 2];
        column3.text = numbers[5, 4];
    }
}

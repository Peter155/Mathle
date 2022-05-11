using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayAnswers : MonoBehaviour
{

    public int[,] numbers;

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

    public void setNumbers(int[,] numbers)
    {
        this.numbers = numbers;

        row1.text = numbers[0, 3].ToString();
        row2.text = numbers[1, 3].ToString();
        row3.text = numbers[2, 3].ToString();

        column1.text = numbers[3, 0].ToString();
        column2.text = numbers[3, 1].ToString();
        column3.text = numbers[3, 2].ToString();
    }
}

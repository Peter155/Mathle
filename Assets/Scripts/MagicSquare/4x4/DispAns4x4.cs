using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DispAns4x4 : MonoBehaviour
{
    public string[,] numbers;

    public TMP_Text row1;
    public TMP_Text row2;
    public TMP_Text row3;
    public TMP_Text row4;

    public TMP_Text column1;
    public TMP_Text column2;
    public TMP_Text column3;
    public TMP_Text column4;

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

        row1.text = numbers[0, 7];
        row2.text = numbers[2, 7];
        row3.text = numbers[4, 7];
        row4.text = numbers[6, 7];

        column1.text = numbers[7, 0];
        column2.text = numbers[7, 2];
        column3.text = numbers[7, 4];
        column4.text = numbers[7, 6];
    }
}

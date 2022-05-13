using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayOperators : MonoBehaviour
{

    public string[,] numbers;

    public TMP_Text row1_2;
    public TMP_Text row1_4;
    public TMP_Text row2_1;
    public TMP_Text row2_3;
    public TMP_Text row2_5;
    public TMP_Text row3_2;
    public TMP_Text row3_4;
    public TMP_Text row4_1;
    public TMP_Text row4_3;
    public TMP_Text row4_5;
    public TMP_Text row5_2;
    public TMP_Text row5_4;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setOperators(string[,] numbers)
    {
        this.numbers = numbers;

        row1_2.text = numbers[0, 1];
        row1_4.text = numbers[0, 3];
        row2_1.text = numbers[1, 0];
        row2_3.text = numbers[1, 2];
        row2_5.text = numbers[1, 4];
        row3_2.text = numbers[2, 1];
        row3_4.text = numbers[2, 3];
        row4_1.text = numbers[3, 0];
        row4_3.text = numbers[3, 2];
        row4_5.text = numbers[3, 4];
        row5_2.text = numbers[4, 1];
        row5_4.text = numbers[4, 3];
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class CheckAnswers : MonoBehaviour
{

    private int[,] inputs;
    public int[,] answers;

    public TMP_InputField box1_1;
    public TMP_InputField box1_2;
    public TMP_InputField box1_3;
    public TMP_InputField box2_1;
    public TMP_InputField box2_2;
    public TMP_InputField box2_3;
    public TMP_InputField box3_1;
    public TMP_InputField box3_2;
    public TMP_InputField box3_3;

    public TMP_InputField[,] boxes;



    // Start is called before the first frame update
    void Start()
    {
        inputs = new int[3, 3];
        boxes = new TMP_InputField[3, 3];

        boxes[0, 0] = box1_1;
        boxes[0, 1] = box1_2;
        boxes[0, 2] = box1_3;
        boxes[1, 0] = box2_1;
        boxes[1, 1] = box2_2;
        boxes[1, 2] = box2_3;
        boxes[2, 0] = box3_1;
        boxes[2, 1] = box3_2;
        boxes[2, 2] = box3_3;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StoreNumbers(int[,] answers)
    {

        this.answers = answers;
        
        /*inputs[0, 0] = int.Parse(box1_1.text);
        inputs[0, 1] = int.Parse(box1_2.text);
        inputs[0, 2] = int.Parse(box1_3.text);
        inputs[1, 0] = int.Parse(box2_1.text);
        inputs[1, 1] = int.Parse(box2_2.text);
        inputs[1, 2] = int.Parse(box2_3.text);
        inputs[2, 0] = int.Parse(box3_1.text);
        inputs[2, 1] = int.Parse(box3_2.text);
        inputs[2, 2] = int.Parse(box3_3.text);*/


        for (int i = 0; i <  3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                inputs[i, j] = int.Parse(boxes[i, j].text);
                Debug.Log(inputs[i, j]);

                if (inputs[i, j] != answers[i, j])
                {
                    boxes[i, j].image.color = Color.red;
                } else
                {
                    boxes[i, j].image.color = Color.green;
                }
            }
        }
    }
}

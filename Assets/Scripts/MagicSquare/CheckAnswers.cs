using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class CheckAnswers : MonoBehaviour
{

    private string[,] inputs;
    public string[,] answers;
    private string[,] ansNums;

    public TMP_InputField box1_1;
    public TMP_InputField box1_2;
    public TMP_InputField box1_3;
    public TMP_InputField box2_1;
    public TMP_InputField box2_2;
    public TMP_InputField box2_3;
    public TMP_InputField box3_1;
    public TMP_InputField box3_2;
    public TMP_InputField box3_3;

    public Button button;
    public TMP_Text triesText;

    public TMP_InputField[,] boxes;

    public WinOrLose winOrLose;

    public int count;

    private int tries;
    private bool win;


    // Start is called before the first frame update
    void Start()
    {
        inputs = new string[3, 3];
        boxes = new TMP_InputField[3, 3];

        tries = 3;
        win = false;

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

    public void DisplaySome(string[,] numbers)
    {
        answers = numbers;

        ansNums = new string[3, 3];

        System.Random random = new System.Random();

        for (int i = 0; i < 5; i = i + 2)
        {
            for (int j = 0; j < 5; j = j + 2)
            {
                ansNums[i / 2, j / 2] = answers[i, j];

                if(int.Parse(ansNums[i/2,j/2]) > 9)
                {
                    boxes[i / 2, j / 2].text = ansNums[i / 2, j / 2];
                    boxes[i / 2, j / 2].interactable = false;
                    count++;
                }
            }
        }

        for (; count < 2; count++)
        {
            int values = ansNums.GetLength(0) * ansNums.GetLength(1);
            int index = random.Next(values);
            int i = index / ansNums.GetLength(0);
            int j = index % ansNums.GetLength(0);
            TMP_InputField current = boxes[i, j];
            if (current.interactable)
            {
                current.text = ansNums[i, j];
                current.interactable = false;
            } else
            {
                count--;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StoreNumbers()
    {

        tries--;
        win = true;

        /*ansNums[0, 0] = answers[0, 0];
        ansNums[0, 1] = answers[0, 2];
        ansNums[0, 2] = answers[0, 4];*/

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
                inputs[i, j] = boxes[i, j].text;
                //Debug.Log(inputs[i, j]);

                if (inputs[i, j] != ansNums[i, j])
                {
                    boxes[i, j].image.color = Color.red;
                    win = false;
                } else
                {
                    boxes[i, j].image.color = Color.green;
                }
            }
        }

        if(win)
        {
            winOrLose.win(tries);
            button.interactable = false;
        } else if(tries == 0)
        {
            triesText.text = "Attempts: " + tries;
            winOrLose.lose();
            button.interactable = false;
        } else
        {
            triesText.text = "Attempts: " + tries;
        }

    }
}

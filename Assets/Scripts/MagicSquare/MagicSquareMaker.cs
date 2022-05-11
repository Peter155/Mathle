using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicSquareMaker : MonoBehaviour
{

    public DisplayAnswers displayCheck;
    public MainManager manager;

    private void Start()
    {
        MagicSquareMaker helloWorld = new MagicSquareMaker();

        int[,] square = helloWorld.MakeMagicSquare(4);

        helloWorld.printSquare(square);

        displayCheck.setNumbers(square);
        manager.numbers = square;
    }

    /*public static void Main(string[] args)
    {
        MagicSquareMaker helloWorld = new MagicSquareMaker();

        int[,] square = helloWorld.MakeMagicSquare(4);

        helloWorld.printSquare(square);
    }*/

    private int[,] MakeMagicSquare(int size)
    {
        int[,] square = new int[size, size];
        System.Random random = new System.Random();

        for (int i = 0; i < size - 1; i++)
        {
            for (int j = 0; j < size - 1; j++)
            {
                //square[i, j] = random.Next(18) - 9;
                square[i, j] = random.Next(9);
            }
        }

        for (int i = 0; i < size - 1; i++)
        {
            int sum = 0;
            for (int j = 0; j < size - 1; j++)
            {
                sum += square[i, j];
            }
            square[i, size - 1] = sum;
        }

        for (int j = 0; j < size - 1; j++)
        {
            int sum = 0;
            for (int i = 0; i < size - 1; i++)
            {
                sum += square[i, j];
            }
            square[size - 1, j] = sum;
        }

        int temp = 0;
        for (int i = 0; i < size - 1; i++)
        {
            temp += square[i, i];
        }
        square[size - 1, size - 1] = temp;

        return square;
    }

    private void printSquare(int[,] square)
    {
        for (int i = 0; i < square.GetLength(0); i++)
        {
            for (int j = 0; j < square.GetLength(1); j++)
            {
                int number = square[i, j];

                if (10 <= number)
                {
                    Debug.Log(" {0}" + number);
                }
                else if (0 <= number & number < 10)
                {
                    Debug.Log("  {0}" + number);
                }
                else if (-10 < number & number < 0)
                {
                    Debug.Log(" {0}" + number);
                }
                else
                {
                    Debug.Log(number);
                }
                //Debug.Log(" ");
            }
            //Debug.Log("\n\n");
        }
    }
}

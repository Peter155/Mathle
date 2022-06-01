using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class NewMagicSquareMaker : MonoBehaviour
{

    public MainManager manager;
    public CheckAnswers check;

    public int size;

    private void Start()
    {
        string[,] magicSquare = MakeMagicSquare(size, size);

        for (int i = 0; i < magicSquare.GetLength(0); i++)
        {
            //Debug.Log("New row");
            for (int j = 0; j < magicSquare.GetLength(1); j++)
            {
                //Debug.Log(magicSquare[i, j]);
            }
            //Debug.Log("/n");
        }

        manager.setDisplay(magicSquare);
        check.DisplaySome(magicSquare);
    }

    private string[,] MakeMagicSquare(int rows, int columns)
    {
        if (rows % 2 != 0 | columns % 2 != 0)
        {
            return null;
        }
        string[,] magicSquare = new string[rows, columns];

        AddOperators(magicSquare);
        AddDivision(magicSquare);
        AddAnswers(magicSquare);

        return magicSquare;
    }

    private void AddOperators(string[,] magicSquare)
    {
        bool isOperator = false;
        string[] operators = new string[] { "+", "-", "*" };
        System.Random random = new System.Random();

        for (int i = 0; i < magicSquare.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < magicSquare.GetLength(1) - 1; j++)
            {
                if ((i % 2 == 0 | j % 2 == 0) & isOperator)
                {
                    magicSquare[i, j] = operators[random.Next(3)];
                }
                else if (i % 2 == 0 | j % 2 == 0)
                {
                    magicSquare[i, j] = random.Next(2, 10).ToString();
                }
                isOperator = !isOperator;
            }
        }
    }

    private void AddDivision(string[,] magicSquare)
    {
        System.Random random = new System.Random();
        HashSet<string> divisionLocations = new HashSet<string>();

        for (int i = 0; i < magicSquare.GetLength(0) - 2; i += 2)
        {
            for (int j = 0; j < magicSquare.GetLength(1) - 2; j += 2)
            {
                if (random.Next(4) == 0)
                {
                    if (!divisionLocations.Contains((i - 2).ToString() + j.ToString()))
                    {
                        if (!divisionLocations.Contains(i.ToString() + (j - 2).ToString()))
                        {
                            if (!divisionLocations.Contains((i - 2).ToString() + (j - 2).ToString()))
                            {
                                magicSquare[i, j] = (int.Parse(magicSquare[i + 2, j]) * int.Parse(magicSquare[i, j + 2])).ToString();
                                magicSquare[i + 1, j] = "/";
                                magicSquare[i, j + 1] = "/";
                                divisionLocations.Add(i.ToString() + j.ToString());
                            }
                        }
                    }
                }
            }
        }
    }

    private void AddAnswers(string[,] magicSquare)
    {
        DataTable dataTable = new DataTable();

        for (int i = 0; i < magicSquare.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < magicSquare.GetLength(1) - 1; j++)
            {
                if (i % 2 == 0)
                {
                    magicSquare[i, magicSquare.GetLength(1) - 1] += magicSquare[i, j];
                }
                if (j % 2 == 0)
                {
                    magicSquare[magicSquare.GetLength(0) - 1, j] += magicSquare[i, j];
                }
            }
        }

        for (int i = 0; i < magicSquare.GetLength(0); i += 2)
        {
            magicSquare[i, magicSquare.GetLength(1) - 1] = dataTable.Compute(magicSquare[i, magicSquare.GetLength(1) - 1], "").ToString();
        }

        for (int j = 0; j < magicSquare.GetLength(1); j += 2)
        {
            magicSquare[magicSquare.GetLength(0) - 1, j] = dataTable.Compute(magicSquare[magicSquare.GetLength(0) - 1, j], "").ToString();
        }
    }
}

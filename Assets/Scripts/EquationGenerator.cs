using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using Unity.Mathematics;

public class EquationGenerator : MonoBehaviour
{

    public int PeterDirt;
    public int level;

    // Start is called before the first frame update
    void Start()
    {
        EquationGenerator helloWorld = new EquationGenerator();
        DataTable dataTable = new DataTable();

        for (int i = 0; i < 1; i++)
        {
            string equation = String.Join(" ", helloWorld.getEquation().ToArray());
            Console.WriteLine(equation);
            Console.WriteLine(dataTable.Compute(equation, ""));
            Debug.Log(equation);
            Debug.Log(dataTable.Compute(equation, ""));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*public static void Main(string[] args)
    {
        EquationGenerator helloWorld = new EquationGenerator();
        DataTable dataTable = new DataTable();

        for (int i = 0; i < 1; i++)
        {
            string equation = String.Join(" ", helloWorld.getEquation().ToArray());
            Console.WriteLine(equation);
            Console.WriteLine(dataTable.Compute(equation, ""));
            Debug.Log(equation);
        }
    }*/

    public List<string> getEquation()
    {
        List<string> equation = new List<string>();
        List<string> operators = new List<string>() { "+", "-", "*", "/" };
        int level = 2;
        System.Random random = new System.Random();

        for (int i = 0; i < 1; i++)
        {
            equation.Add(random.Next(2, 9).ToString());
            equation.Add(operators[random.Next(level)]);
        }
        equation.Add(random.Next(2, 9).ToString());

        for (int i = 0; i < equation.Count - 2; i++)
        {
            if (equation[i] == "/" & equation[i + 2] == "/")
            {
                equation[i + 2] = operators[random.Next(3)];
            }
        }

        for (int i = equation.Count - 1; i >= 0; i--)
        {
            if (equation[i] == "/")
            {
                equation[i - 1] = (Int32.Parse(equation[i + 1]) * random.Next(2, 9)).ToString();
            }
        }

        return equation;
    }
}

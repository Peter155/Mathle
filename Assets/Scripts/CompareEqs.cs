using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Data;

public class CompareEqs : MonoBehaviour
{

    public string answer;
    public string attempt;
    public TMP_Text result;
    public TMP_Text playerResult;
    private DataTable dataTable;

    public EquationGenerator eqGen;

    // Start is called before the first frame update
    void Start()
    {
        dataTable = new DataTable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckAnswer()
    {
        answer = answer.Replace(" ", string.Empty);
        if (attempt == answer)
        {
            Debug.Log("Correct");
            result.text = "Correct";
            playerResult.text = (dataTable.Compute(attempt, "")).ToString();
            Debug.Log(dataTable.Compute(attempt, ""));
            eqGen.genEquation();
            //return true;
        }
        else
        {
            Debug.Log("Incorrect");
            result.text = "Incorrect";
            playerResult.text = (dataTable.Compute(attempt, "")).ToString();
            Debug.Log(dataTable.Compute(attempt, ""));
        }

        //return false;

        //Console.WriteLine(dataTable.Compute(equation, ""));
    }
}

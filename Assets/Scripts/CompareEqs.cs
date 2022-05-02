using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompareEqs : MonoBehaviour
{

    public string answer;
    public string attempt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool CheckAnswer()
    {
        if (attempt == answer)
        {
            return true;
        }

        return false;

        //Console.WriteLine(dataTable.Compute(equation, ""));
    }
}

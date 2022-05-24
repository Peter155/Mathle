using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager4x4 : MonoBehaviour
{
    public CheckAns4x4 checker;
    public DispAns4x4 displayAns;
    public DispOps4x4 displayOp;

    public string[,] numbers;

    public GameObject[,] squares;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setDisplay(string[,] numbers)
    {
        this.numbers = numbers;
        displayAns.setNumbers(numbers);
        displayOp.setOperators(numbers);
    }

    public void Submit()
    {
        checker.StoreNumbers();
    }
}

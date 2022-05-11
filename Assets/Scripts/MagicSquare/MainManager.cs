using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{

    public CheckAnswers checker;

    public int[,] numbers;

    public GameObject[,] squares;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Submit()
    {
        checker.StoreNumbers(numbers);
    }
}

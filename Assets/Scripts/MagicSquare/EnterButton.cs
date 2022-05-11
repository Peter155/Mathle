using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterButton : MonoBehaviour
{

    public MainManager manager;

    void EnterGuess()
    {
        manager.Submit();
    }
}

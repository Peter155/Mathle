using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterButton4x4 : MonoBehaviour
{
    public MainManager4x4 manager;

    void EnterGuess()
    {
        manager.Submit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAgainButton : MonoBehaviour
{

    public WinOrLose restarter;

    public void Restart()
    {
        restarter.playAgain();
    }

    public void nextLevel()
    {
        restarter.nextLevel();
    }
}

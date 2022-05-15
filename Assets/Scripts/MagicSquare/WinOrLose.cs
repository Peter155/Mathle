using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class WinOrLose : MonoBehaviour
{

    public GameObject winScreen;
    public TMP_Text winMessage;

    public GameObject loseScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void win(int tries)
    {
        winScreen.SetActive(true);
        
        if(tries == 2)
        {
            winMessage.text = "Perfect score!";
        } else if (tries == 1)
        {
            winMessage.text = "Good job!";
        } else
        {
            winMessage.text = "Close one!";
        }
    }

    public void lose()
    {
        loseScreen.SetActive(true);
    }

    public void playAgain()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}

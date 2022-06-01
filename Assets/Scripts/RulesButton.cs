using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RulesButton : MonoBehaviour
{
    public GameObject rulesScreen;

    public AudioSource open;
    public AudioSource close;

    public void ToggleRules()
    {
        if(rulesScreen.activeSelf) {
            rulesScreen.SetActive(false);
            close.Play();
        } else {
            rulesScreen.SetActive(true);
            open.Play();
        }
    }
}

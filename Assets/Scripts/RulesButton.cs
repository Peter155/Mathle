using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RulesButton : MonoBehaviour
{
    public GameObject rulesScreen;
    public void ToggleRules()
    {
        if(rulesScreen.activeSelf) {
            rulesScreen.SetActive(false);
        } else {
            rulesScreen.SetActive(true);
        }
    }
}

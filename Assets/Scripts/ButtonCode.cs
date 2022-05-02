using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCode : MonoBehaviour
{

    private Button thisButton;
    public InputReader Handler;
    public string thisString;

    

    // Start is called before the first frame update
    void Start()
    {
        thisButton = this.GetComponent<Button>();
        thisButton.onClick.AddListener(Pressed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pressed()
    {
        Handler.SendInput(thisString);
    }

    
}

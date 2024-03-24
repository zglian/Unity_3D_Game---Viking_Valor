using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpButton : MonoBehaviour
{
    public GameObject HelpScene;
    // Start is called before the first frame update
    public void ClickHelp()
    {
        HelpScene.SetActive(true);
            
    }
}

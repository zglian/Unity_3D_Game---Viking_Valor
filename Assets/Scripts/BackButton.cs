using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    //public GameObject MenuScene;
    public GameObject HelpScene;
    public void BackClick()
    {
       // MenuScene.SetActive(true);
        HelpScene.SetActive(false);

    }
}

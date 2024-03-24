using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
            Debug.Log("1");
            SceneManager.LoadScene(1);
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}

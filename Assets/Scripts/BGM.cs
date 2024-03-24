using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audiosource;
    
    //bool isplay = false;
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        audiosource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.P))
        {
            isplay = !isplay;
        }
        if(audiosource.isPlaying && !isplay)
        {
            audiosource.Stop();

        }
        if(!audiosource.isPlaying && isplay)
        {
            audiosource.Play();
        }*/
        
    }
}

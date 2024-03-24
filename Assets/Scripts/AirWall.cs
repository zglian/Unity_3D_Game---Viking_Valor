using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirWall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name == "viking")
        {
            Debug.Log("Viking just hit the wall");
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.transform.name == "viking")
        {
            Debug.Log("Viking is hitting the wall");
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if(collision.transform.name == "viking")
        {
            Debug.Log("Viking left the wall");
        }
    }
}

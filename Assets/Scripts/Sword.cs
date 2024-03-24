using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sword : MonoBehaviour
{
    
    public int damgaeAmount = 20;
    
    private void Start()
    {
        //GetComponent<Text>().text = coins + totalCoins;
    }
    

    private void OnCollisionStay(Collision collision)
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("collide with other");
            if (collision.transform.tag == "Enemy")
            {
                collision.transform.GetComponent<EnemyController>().TakeDamage(damgaeAmount);
                Debug.Log("Attack");
            }           
        }
        if (Input.GetKey(KeyCode.F))
        {
            if (collision.transform.tag == "Coins")
            {
                Debug.Log("collect coins");
                Destroy(collision.gameObject);
                textScript.totalCoins += 10;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("collide with other");
            if (collision.transform.tag == "Enemy")
            {
                collision.transform.GetComponent<EnemyController>().TakeDamage(damgaeAmount);
                Debug.Log("Attack");
            }
        }
        if (Input.GetKey(KeyCode.F))
        {
            if (collision.transform.tag == "Coins")
            {
               
                Debug.Log("collect coins");
                Destroy(collision.gameObject);
                textScript.totalCoins += 10;
            }
        }
    }
   
}

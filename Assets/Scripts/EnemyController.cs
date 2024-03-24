using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{

    private int HP = 100;
    public Slider healthBar;
    public Animator animator;
    public GameObject Coins;
    
    private void Update()
    {
        healthBar.value = HP;
        

    }

    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;
        if(HP <= 0)
        {
            animator.SetTrigger("die");
            //GetComponent<Collider>().enabled = false;

            Vector3 move = gameObject.transform.position;
            //Debug.Log("die");
            Instantiate(Coins, move, Quaternion.identity);
            
            //Debug.Log("create coins");
        }
        else
        {
            animator.SetTrigger("damage");
            Debug.Log("damage");
            //animator.SetBool("damage", false);

        }
    }
}

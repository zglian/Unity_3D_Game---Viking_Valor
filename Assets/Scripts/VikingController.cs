using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VikingController : MonoBehaviour
{
    public GameObject LostScreen;
    public GameObject PauseButton;
    public int HP = 500;
    public Slider healthBar;
    public Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
       
    }
    void Update()
    {
        healthBar.value = HP;        
    }
    public void TakeDamage(int damageAmount)
    {
        HP -= damageAmount;
        if (HP <= 0)
        {
            animator.SetTrigger("die");
            LostScreen.SetActive(true);
            PauseButton.SetActive(false);
            Time.timeScale = 0;

            Debug.Log("die player");
        }
        else
        {
            animator.SetTrigger("damage");
            Debug.Log("damage player");

        }
    }

}


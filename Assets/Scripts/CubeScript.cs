using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class CubeScript : MonoBehaviour
{
    //Transform Enemy;//

    public Vector3 MovingDirection;
    
    MeshRenderer mr;
    [SerializeField]float movingSpeed = 10f;
    [SerializeField] float jumpForce = 1000;
    

    Rigidbody rb;
    Animator animator;
    AudioSource footstep;
    bool run;
    NavMeshAgent agent;
    RaycastHit raycastHit;
    Vector2 velocity = Vector2.zero;
    bool on_ground;
    float axis  = 0f;
    public GameObject EndgameScene;
   


    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        footstep = GetComponent<AudioSource>();
        if(Time.timeScale != 0)
        {
            EndgameScene.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        animator.SetFloat("speed", 0f);
        run = false;
        animator.SetBool("run", false);
        animator.SetBool("attack", false);
        
        if(Time.timeScale != 0)
        {
            if (Input.GetKey(KeyCode.W))
            {

                transform.Translate(0, 0, movingSpeed);
                animator.SetFloat("speed", 1f);
                run = true;
            }
            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
            {

                transform.Translate(0, 0, movingSpeed * 2);
                animator.SetFloat("speed", 1f);
                animator.SetBool("run", true);
                run = true;
            }
            if (Input.GetKey(KeyCode.S))
            {

                transform.Translate(0, 0, -movingSpeed);
                animator.SetFloat("speed", 1f);
                run = true;

            }
            if (Input.GetKey(KeyCode.A))
            {

                transform.Translate(-movingSpeed, 0, 0);
                animator.SetFloat("speed", 1f);
                run = true;
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(movingSpeed, 0, 0);
                animator.SetFloat("speed", 1f);
                run = true;
            }

            if (Input.GetMouseButtonDown(0))
            {
                animator.SetBool("attack", true);

            }
            if (run && !footstep.isPlaying)
            {
                footstep.Play();
            }
            if (!run && footstep.isPlaying)
            {
                footstep.Stop();
            }

            if (Input.GetKey(KeyCode.Space))
            {
                if (on_ground)
                {
                    rb.AddForce(jumpForce * Vector3.up);
                    animator.SetBool("jump", true);
                    //Debug.Log("jump");
                    on_ground = false;
                }

            }
            if (Input.GetAxis("Mouse X") != axis)
            {
                transform.Rotate(0, Input.GetAxis("Mouse X"), 0, Space.Self);
                axis = Input.GetAxis("Mouse X");
            }
            else
            {
                transform.Rotate(0, 0, 0, Space.Self);
            }
            
        }
        
        

    }
    private void OnCollisionStay(Collision collision)
    {
        
        animator.SetBool("jump", false);
        if (collision.transform.tag == "Ground" || collision.transform.tag == "Respawn")
        {
            on_ground = true;
            Debug.Log("ground");
            
        }
        
    }
}

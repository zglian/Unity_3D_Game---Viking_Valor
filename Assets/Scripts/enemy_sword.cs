using UnityEngine;

public class enemy_sword : MonoBehaviour
{
    public int damgaeAmount = 20;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            damgaeAmount = 20;
            collision.transform.GetComponent<VikingController>().TakeDamage(damgaeAmount);
            Debug.Log("player is being attaked");
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            damgaeAmount = 1;
            collision.transform.GetComponent<VikingController>().TakeDamage(damgaeAmount);
            Debug.Log("player is being attaked");
        }
    }


}

using UnityEngine;

public class GroundCollide : MonoBehaviour
    
{
    GroundSpawner _GroundSpawner;
    // Start is called before the first frame update
    void Start()
    {
        _GroundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.transform.tag == "Respawn")
        {
            Debug.Log("collide");
            _GroundSpawner.SpawnTile();
        }
        
    }
    
        
    
    // Update is called once per frame
    void Update()
    {
        
    }
}

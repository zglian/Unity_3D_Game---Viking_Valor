using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject ground;
    //public GameObject player;
    float playerPosX, playerPosZ;
    // Start is called before the first frame update
    public void SpawnTile()
    {
        playerPosX = GameObject.FindGameObjectWithTag("Player").transform.position.x;
        playerPosZ = GameObject.FindGameObjectWithTag("Player").transform.position.z;
        //playerPos = player.transform.position;
        Vector3 pos = new Vector3(playerPosX, 0, playerPosZ);
        Instantiate(ground, pos, Quaternion.identity);
    }
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}

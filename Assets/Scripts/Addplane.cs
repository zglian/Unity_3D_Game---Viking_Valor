using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addplane : MonoBehaviour
{
    const float width = 10f;
    public Transform player;
    Vector3 initPos;

    // Start is called before the first frame update
    void Start()
    {
        initPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float totalWidth = width * 2f;
        float distZ = player.position.z - initPos.z;
        int n = Mathf.RoundToInt(distZ / totalWidth);

        var pos = initPos;
        pos.z += n * totalWidth;
        transform.position = pos;


        
    }
}

using System.Collections;
using UnityEngine;


public class BlockFalling : MonoBehaviour
{
    float t;
    float time = 3.0f;
    //  Vector3 newPos = 
    void Update()
    {
        t += Time.deltaTime;
        if (t >= time)
        {
            t = 0.0f;
            transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
        }
    }
}


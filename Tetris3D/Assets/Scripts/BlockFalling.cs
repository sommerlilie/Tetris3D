using System.Collections;
using UnityEngine;


public class BlockFalling : MonoBehaviour
{
    float t;
    float time = 1.5f;
    void Update()
    {
        t += Time.deltaTime;
        if (t >= time)
        {
            t = 0.0f;
            // block falls one unit per time
            transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
        }
    }
}


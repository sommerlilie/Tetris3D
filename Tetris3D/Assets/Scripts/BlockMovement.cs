using UnityEngine;
using System.Collections;

public class BlockMovement : MonoBehaviour
{
    public Transform target;
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.J))
        {
            transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
        }
        //TOdo get orientation of camera to control direction of block movement

    }
}




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public float speed;
    public Transform target;


    void Update()
    {


        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
            // transform.RotateAround(target.position, transform.right, -Input.GetAxis("Vertical") * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -Vector3.up * speed * Time.deltaTime;
            // transform.RotateAround(target.position, transform.right, -Input.GetAxis("Vertical") * speed);
        }


        if (Input.GetAxis("Horizontal") != 0)
        {
            transform.RotateAround(target.position, transform.up, -Input.GetAxis("Horizontal") * speed);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public float speed;
    public Transform target;



    void Update()
    {
        Vector3 rot = transform.rotation.eulerAngles;
        rot = new Vector3(rot.x, rot.y + 90f, rot.z);

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


        if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(target.position, transform.up, -Input.GetAxis("Horizontal") * speed);
        }
    }
}

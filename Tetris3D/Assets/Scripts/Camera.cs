using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public float speed;
    public Transform target;
    float time = 1.0f;
    bool triggerd = false;
    float angle = 0;
    Vector3 old_rot;

    void Update()
    {
        Vector3 rot = transform.rotation.eulerAngles;
        rot = new Vector3(rot.x, rot.y + 90f, rot.z);

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -Vector3.up * speed * Time.deltaTime;
            // transform.RotateAround(target.position, transform.right, -Input.GetAxis("Vertical") * speed);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.RotateAround(target.position, transform.up, 90);
        }


        //  transform.RotateAround(target.position, transform.up, -Input.GetAxis("Horizontal") * speed);
    }
    void Rotating()
    {
        Vector3 oldRotation = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z);
        Vector3 newRotation = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z + 90f);
        transform.position = Vector3.Slerp(oldRotation, newRotation, .05f);
    }
}





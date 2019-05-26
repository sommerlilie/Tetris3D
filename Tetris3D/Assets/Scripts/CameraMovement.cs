using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
	[SerializeField]
    public float speed;
	[SerializeField]
    public Transform target;

    void Update()
    {
        Vector3 rot = transform.rotation.eulerAngles;
        rot = new Vector3(rot.x, rot.y + 90f, rot.z);

        if (Input.GetKey(KeyCode.W))
        {
			transform.Translate(Vector3.up * speed * Time.deltaTime);
			Debug.Log("W");
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector3.up * speed * Time.deltaTime);
			Debug.Log("S");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.RotateAround(target.position, transform.up, 90f);
			Debug.Log("D");
        }

		if (Input.GetKeyDown(KeyCode.A))
        {
            transform.RotateAround(target.position, transform.up, -90f);
			Debug.Log("A");
		}


    }
}

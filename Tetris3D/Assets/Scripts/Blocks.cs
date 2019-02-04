using System.Collections;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    public float fallSpeed;

    void Update()
    {
        //  this.transform.RotateAround(transform.position, transform.up, 90);
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);

        if (Input.GetKeyDown(KeyCode.I))
        {
            transform.Rotate(0, transform.rotation.y + 90f, 0);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            transform.Rotate(0, transform.rotation.y - 90, 0);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            transform.Rotate(0, 0, transform.rotation.z + 90);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            transform.Rotate(0, 0, transform.rotation.z - 90);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fallSpeed += 10;
        }


    }
}
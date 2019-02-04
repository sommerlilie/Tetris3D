using System.Collections;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    public float fallSpeed = 8.0f;

    void Update()
    {

        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);

        if (Input.getKey(KeyCode.UpArrow))
        {
            transform.RotateAround(transform.position, transform.up, 90);
        }
    }
}
using System.Collections;
using UnityEngine;

public class BlockRotation : MonoBehaviour
{
    public float fallSpeed;

    void Update()
    {
        //  this.transform.RotateAround(transform.position, transform.up, 90);
        //  transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);

        //   transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
        Vector3 rot = transform.rotation.eulerAngles;
        Vector3 rot_v;
        Vector3 rot_h;
        Vector3 rot_x;
        Vector3 rot_sonderfall;
        rot_v = new Vector3(rot.x, rot.y + 90, rot.z);
        rot_h = new Vector3(rot.x, rot.y, rot.z + 90);
        rot_x = new Vector3(rot.x + 90, rot.y, rot.z);
        rot_sonderfall = new Vector3(-130, 0, 0);


        if (Input.GetKeyDown(KeyCode.I))
        {
            // transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y + 90f, transform.rotation.z);
            transform.rotation = Quaternion.Euler(rot_v);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            if (rot.x < 100 && rot.x > 98 && rot.y != 180)
            {
                print("#");
                transform.rotation = Quaternion.Euler(rot_x);
            }
            if (rot.y == 180 && rot.z < 100 && rot.z > 98)
            {
                print("#");
                transform.rotation = Quaternion.Euler(rot_sonderfall);
            }
            transform.rotation = Quaternion.Euler(rot_h);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            transform.Rotate(0, 0, transform.rotation.z + 90f);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            transform.Rotate(0, 0, transform.rotation.z - 90f);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fallSpeed += 10;
        }


    }
}
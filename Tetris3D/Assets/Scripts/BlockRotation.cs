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
        rot_v = new Vector3(rot.x, rot.y + 90f, rot.z);
        rot_h = new Vector3(rot.x, rot.y, rot.z + 90f);

        // rotation around y axis
        if (Input.GetKeyDown(KeyCode.K))
        {
            // transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y + 90f, transform.rotation.z);
            transform.rotation = Quaternion.Euler(rot_v);
        }
        // rotation around z axis
        if (Input.GetKeyDown(KeyCode.I))
        {
            /* if (rot.x < 100 && rot.x > 98 && rot.y != 180)
            {
                print("first");
                transform.rotation = Quaternion.Euler(rot_x);
            }
            if (rot.y == 180 && rot.z < 100 && rot.z > 98)
            {
                print("second");
                transform.rotation = Quaternion.Euler(rot_sonderfall);
            }
            else
            {*/
            print("third");
            transform.rotation = Quaternion.Euler(rot_h);
            //}

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fallSpeed += 10;
        }


    }
}
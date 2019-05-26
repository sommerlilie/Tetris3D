using System.Collections;
using UnityEngine;

public class BlockRotation : MonoBehaviour
{
    public float fallSpeed;

    void Update()
    {
		
        Vector3 rot = transform.rotation.eulerAngles;
        Vector3 rot_v = new Vector3(rot.x, rot.y + 90f, rot.z);
        Vector3 rot_h = new Vector3(rot.x, rot.y, rot.z + 90f);

        // rotation around y axis
        if (Input.GetKeyDown(KeyCode.K))
        {
			Debug.Log("Vertical_Rotate");
            transform.rotation = Quaternion.Euler(rot_v);
        }
        // rotation around z axis
        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("Horizontal_Rotate");
            transform.rotation = Quaternion.Euler(rot_h);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fallSpeed += 10;
        }
    }
}

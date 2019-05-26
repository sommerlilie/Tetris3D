using UnityEngine;
using System.Collections;

public class BlockMovement : MonoBehaviour {
		Transform camera;

	    float cameraValue;
	    float cameraValuez;

	void Start() {
		 camera = GameObject.FindGameObjectWithTag("MainCamera").transform;
	}



    void Update()
    {
        float camera_Value = camera.transform.eulerAngles.y;

        switch (camera_Value)
        {
            case 0:
                cameraValue = 1;
                cameraValuez = 0;
                break;
            case 90:
                cameraValue = 0;
                cameraValuez = -1;
                break;
            case 180:
                cameraValue = -1;
                cameraValuez = 0;
                break;
            case 270:
                cameraValue = 0;
                cameraValuez = 1;
                break;
            default:
                cameraValue = 2;
				Debug.LogError("No Matching Case");
                break;
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            transform.position = new Vector3(transform.position.x - (1 * cameraValue), transform.position.y, transform.position.z - (1 * cameraValuez));

            Debug.Log(cameraValue);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            transform.position = new Vector3(transform.position.x + (1 * cameraValue), transform.position.y, transform.position.z + (1 * cameraValuez));
        }
    }
}

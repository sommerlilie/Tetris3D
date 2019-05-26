using System.Collections;
using UnityEngine;


public class BlockFalling : MonoBehaviour
{
    float t;
    float time = 1.5f;
	bool moving = true;
    void Update()
    {
		if(moving) {
        t += Time.deltaTime;
        if (t >= time)
        {
            t = 0.0f;
            // block falls one unit per time
            transform.position = new Vector3(transform.position.x, transform.position.y - 1, transform.position.z);
        	}
    	}
	}
	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.name == "Base") {
		moving = false;
		Debug.Log("Collided");
		}
	}
}

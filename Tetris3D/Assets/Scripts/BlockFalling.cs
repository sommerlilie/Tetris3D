using System.Collections;
using UnityEngine;


public class BlockFalling : MonoBehaviour
{	public Spawner sp = new Spawner();
    float t;
    float time = 1.5f;
	bool moving = true;
	void Start() {
}
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
	(gameObject.GetComponent( "BlockFalling" ) as MonoBehaviour).enabled = false;
	(gameObject.GetComponent( "BlockMovement" ) as MonoBehaviour).enabled = false;
	(gameObject.GetComponent( "BlockRotation" ) as MonoBehaviour).enabled = false;
	Debug.LogError("Disabled Scripts");
//	sp = GameObject.Find("Spawner").GetComponent<Spawner>();
	sp.SpawnNext();
	}


}

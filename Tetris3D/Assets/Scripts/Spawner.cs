using System.Collections;
using UnityEngine;

public class Spawner: MonoBehaviour { 
	[SerializeField]
	GameObject[] forms = {};
	void Start() {
		SpawnNext();
	}
	public void SpawnNext() {
		int i = Random.Range(0, forms.Length);
		// Spawn Group at center position
		Instantiate(forms[i], new Vector3(5, 10, 5), Quaternion.identity);
		Debug.Log("Spawend Form");
	}

}

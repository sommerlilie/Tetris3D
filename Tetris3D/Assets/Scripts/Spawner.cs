using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour {
	[SerializeField]
	GameObject[] forms = {};

	void Start() {
//	 forms = Resources.LoadAll("MyItemsToLoad") as GameObject[];
//	 Debug.Log(forms);
	 SpawnNext();
	}

	public void SpawnNext() {
	int i = Random.Range(0, forms.Length);
	// Spawn Group at current Position
	Instantiate(forms[i]);
	Debug.Log("Spawend Form");
	}
}

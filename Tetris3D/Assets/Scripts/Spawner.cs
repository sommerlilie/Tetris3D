using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour {
	GameObject[] forms;

	public void SpawnNext() {
    int i = Random.Range(0, forms.Length);

    // Spawn Group at current Position
    Instantiate(forms[i], transform.position, Quaternion.identity);

	void Start() {
	 forms = Resources.LoadAll("MyItemsToLoad") as GameObject[];
	 SpawnNext();
	}
  }
}

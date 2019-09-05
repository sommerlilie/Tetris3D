using System.Collections;
using UnityEngine;

public class GameController: MonoBehaviour { [SerializeField]
	Transform cam;
	float cameraValue;
	float cameraValuez;
	public float fallSpeed;
	[SerializeField]
	float t;
	float time = 0.5f;
	void Start() {
		cam = GameObject.FindGameObjectWithTag("MainCamera").transform;
		if (!IsValidGridPos()) {
			Debug.Log("GAME OVER");
			Destroy(gameObject);
		}
	}

	void Update() {
		t += Time.deltaTime;
		// block falls one unit per time
		if (t >= time) {
			t = 0.0f;
			transform.position = new Vector3((int) transform.position.x, (int) transform.position.y - 1, (int) transform.position.z);
			// See if valid
			if (IsValidGridPos()) {
				// It's valid. Update grid.
				UpdateGrid();
			} else {
				// It's not valid. revert.
				transform.position = new Vector3((int) transform.position.x, (int) transform.position.y + 1, (int) transform.position.z);
				// Clear filled horizontal lines
				Grid.DeleteFullPlate();
				// Spawn next Group
				FindObjectOfType < Spawner > ().SpawnNext();
				// Disable script
				enabled = false;
			}

		}
		//MOVEMENT
		float camera_Value = cam.transform.eulerAngles.y;

		switch (camera_Value) {
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

		if (Input.GetKeyDown(KeyCode.J)) {
			transform.position = new Vector3((int) transform.position.x - (1 * cameraValue), (int) transform.position.y, (int) transform.position.z - (1 * cameraValuez));
			if (IsValidGridPos())
			// It's valid. Update grid.
			UpdateGrid();
			else
			// Its not valid. revert.
			transform.position = new Vector3((int) transform.position.x + (1 * cameraValue), (int) transform.position.y, (int) transform.position.z + (1 * cameraValuez));

		}
		if (Input.GetKeyDown(KeyCode.L)) {
			transform.position = new Vector3((int) transform.position.x + (1 * cameraValue), (int) transform.position.y, (int) transform.position.z + (1 * cameraValuez));

			if (IsValidGridPos())
			// It's valid. Update grid.
			UpdateGrid();
			else
			// Its not valid. revert.
			transform.position = new Vector3((int) transform.position.x - (1 * cameraValue), (int) transform.position.y, (int) transform.position.z - (1 * cameraValuez));
		}

		//ROTATION
		Vector3 rot = transform.rotation.eulerAngles;
		Vector3 rot_v = new Vector3((int) rot.x, (int) rot.y + 90f, (int) rot.z);
		Vector3 rot_h = new Vector3((int) rot.x + 90f, (int) rot.y, (int) rot.z);
		Vector3 rot_z = new Vector3((int) rot.x, (int) rot.y, (int) rot.z + 90f);
		Vector3 rot_rv = new Vector3((int) rot.x, (int) rot.y - 90f, (int) rot.z);
		Vector3 rot_rh = new Vector3((int) rot.x - 90f, (int) rot.y, (int) rot.z);
		Vector3 rot_rz = new Vector3((int) rot.x, (int) rot.y, (int) rot.z - 90f);

		// rotation around y axis
		if (Input.GetKeyDown(KeyCode.U)) {
			Debug.Log("Vertical_Rotate");
			transform.rotation = Quaternion.Euler(rot_v);
			if (IsValidGridPos())
			// It's valid. Update grid.
			UpdateGrid();
			else
			// Its not valid. revert.
			transform.rotation = Quaternion.Euler(rot_rv);

		}

		// rotation around x axis
		if (Input.GetKeyDown(KeyCode.I)) {

			Debug.Log("Horizontal_Rotate");
			transform.rotation = Quaternion.Euler(rot_h);
			if (IsValidGridPos())
			// It's valid. Update grid.
			UpdateGrid();
			else
			// Its not valid. revert.
			transform.rotation = Quaternion.Euler(rot_rh);
		}

		// rotation around z axis
		if (Input.GetKeyDown(KeyCode.O)) {

			Debug.Log("Z_Rotate");
			transform.rotation = Quaternion.Euler(rot_z);
			if (IsValidGridPos())
			// It's valid. Update grid.
			UpdateGrid();
			else
			// Its not valid. revert.
			transform.rotation = Quaternion.Euler(rot_rz);
		}
		if (Input.GetKeyDown(KeyCode.Space)) {
			fallSpeed += 10;
		}
	}

	bool IsValidGridPos() {
		foreach(Transform child in transform) {
			Vector3 v = Grid.RoundVec3(child.position);
			if (!Grid.InsideBorder(v)) return false;
			if (Grid.grid[(int) v.x, (int) v.y, (int) v.z] != null && Grid.grid[(int) v.x, (int) v.y, (int) v.z].parent != transform) return false;
		}
		return true;
	}

	void UpdateGrid() {
		for (int y = 0; y < Grid.h; ++y)
		for (int x = 0; x < Grid.w; ++x)
		for (int z = 0; z < Grid.d; ++z)
		if (Grid.grid[x, y, z] != null) if (Grid.grid[x, y, z].parent == transform) Grid.grid[x, y, z] = null;

		foreach(Transform child in transform) {
			Vector3 v = Grid.RoundVec3(child.position);
			Grid.grid[(int) v.x, (int) v.y, (int) v.z] = child;
		}
	}

}

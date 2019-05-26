using System.Collections;
using UnityEngine;

public class Grid : MonoBehaviour {
	public static int x = 10;
    public static int y = 20;
	public static int z = 20;
    public static Transform[,,] grid = new Transform[x,y,z];

	public static Vector2 roundVec3(Vector3 v) {
    return new Vector3(Mathf.Round(v.x), Mathf.Round(v.y), Mathf.Round(v.z));
	}

	public static void deleteRow(int y) {
    for (int i = 0; i < x; i++) {
		for(int j = 0; j < z; j++) {
			Destroy(grid[x, y, z].gameObject);
			grid[x, y, z] = null;
			}
    	}
	}

	public static void deleteColumn(int x) {
    for (int i = 0; i < z; i++) {
		for(int j = 0; j < y; j++) {
			Destroy(grid[x, y, z].gameObject);
			grid[x, y, z] = null;
			}
    	}
	}

	public static void decreaseOneRow(int y) {
    for (int i = 0; i < x; x++) {
		for(int j = 0; j < z; j++) {
        if (grid[x, y,z] != null) {
            // Move one towards bottom
            grid[x, y-1, z] = grid[x, y, z];
            grid[x, y, z] = null;

            // Update Block position
            grid[x, y-1, z].position += new Vector3(0, -1, 0);
        		}
    		}
		}
	}

	public static void decreaseAllRows(int h) {
    for (int i = h; i < y; i++)
        decreaseOneRow(i);
	}

	public static bool isRowFull(int y) {
    for (int i = 0; i < x; i++) {
		for(int j = 0; j < z; j++) {
			if (grid[x, y, z] == null)
	            return false;
			}
		}
    	return true;
	}

	public static bool isColumnFull(int z) {
	for (int i = 0; i < x; i++) {
		for(int j = 0; j < y; j++) {
			if (grid[x, y, z] == null)
				return false;
			}
		}
		return true;
	}
}

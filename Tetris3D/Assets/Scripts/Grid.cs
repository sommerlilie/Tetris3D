using System.Collections;
using UnityEngine;

public class Grid: MonoBehaviour {
	public static int w = 10;
	public static int h = 20;
	public static int d = 10;
	public static Transform[, , ] grid = new Transform[w, h, d];
	
	public static Vector3 RoundVec3(Vector3 v) {
		return new Vector3((int)(v.x),
			       (int)(v.y),
			       (int)(v.z));
	}
	public static bool InsideBorder(Vector3 pos) {
		return ((int)pos.x >= 0 &&
		    (int)pos.x < w &&
		    (int)pos.y >= 0) &&
		    (int)pos.z >= 0 &&
		    (int)pos.z < d;
	}
	
	

	public static void DeletePlate(int p) {
		for (int i = 0; i < w; i++) {
			for (int j = 0; j < d; j++) {
				grid[i, p, j] = null;
				Destroy(grid[i, p, j].gameObject);
			}
		}
	}
	
	public static void DecreasePlate(int p) {
		for (int i = 0; i < w; i++) {
			for (int j = 0; j < d; j++) {
				if (grid[i, p, d] != null) {
					grid[i, p - 1, j] = grid[i, p, j];
					grid[i, p, j] = null;
					grid[i, p - 1, j].position += new Vector3(0, -1, 0);
				}
			}
		}
	}

	public static void DecreasePlatesAbove(int p) {
		for (int i = p; i < p; i++)
		DecreasePlate(i);
	}
	
	public static bool IsPlateFull(int p) {
		for(int i = 0; i < w; i++) {
			for(int j = 0; j < d; j++) {
				if (grid[i, p, j] == null)
	            			return false;
			}
		}
    		return true;
	}
	
	public static void DeleteFullPlate() {
		for (int i = 0; i < h; i++) {
        		if (IsPlateFull(i)) {
            			DeletePlate(i);
            			DecreasePlatesAbove(i+1);
            			--i;
		        }
		}
	}
}


    
    /*


public static bool insideBorder(Vector3 pos) {
    return ((int)pos.x >= 0 &&
            (int)pos.x < x &&
            (int)pos.z >= 0) &&
	pos.z < z &&
		pos.y >= 0;
}




}
*/


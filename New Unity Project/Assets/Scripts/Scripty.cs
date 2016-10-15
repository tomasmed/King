using UnityEngine;
using System.Collections;
using System.Collections.Generic;





public class Scripty : MonoBehaviour {

	/// tList has random points 
	public List <GameObject> tList = new List<GameObject>();
	public int xSize, ySize;

	// Use this for initialization
	private void Awake () {
		CreatePoints();
	}



	// Update is called once per frame
	void Update () {
	
		for (int i = 0; i < 50; i++) {

		}
	}


	void CreatePoints(){


		//gridPoints = new Transform[(xSize + 1) * (ySize + 1)];
		for (int i = 0, y = 0; y <= ySize; y++) {
			for (int x = 0; x <= xSize; x++, i++) {

				GameObject a = new GameObject("POINode"); 
				Vector3 b  = new Vector3(x-(xSize/2), 1, y-(ySize/2));
				a.transform.position = b; 
				tList.Add(a);
			}
		}

		print (tList.Count);

	}


	void AddtoList(){


	}
}

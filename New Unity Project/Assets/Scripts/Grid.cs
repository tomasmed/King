using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class Grid : MonoBehaviour {

	public int xSize, ySize;

	private void Awake () {
		Generate();
	}


	public static Vector3[] vertices;
	//public Transform[] gridPoints;

	private void Generate () {
		vertices = new Vector3[(xSize + 1) * (ySize + 1)];
		//gridPoints = new Transform[(xSize + 1) * (ySize + 1)];
		for (int i = 0, y = 0; y <= ySize; y++) {
			for (int x = 0; x <= xSize; x++, i++) {
				vertices[i] = new Vector3(x-(xSize/2), 1, y-(ySize/2));
				//gridPoints[i].position = new Vector3(x-(xSize/2), 1, y-(ySize/2));
			}
		}
	}


	private void OnDrawGizmos () {

		if (vertices == null) {
			return;
		}

		Gizmos.color = Color.black;
		for (int i = 0; i < vertices.Length; i++) {
			GameObject tmp = new GameObject ("PoI");
			tmp.transform.position = vertices[i];
		}
	}



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

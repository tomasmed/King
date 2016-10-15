using UnityEngine;
using System.Collections;

public class Sphere : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		MoveTo.goal = transform; 
		print (MoveTo.goal);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

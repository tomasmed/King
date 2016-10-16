using UnityEngine;
using System.Collections;

public class Agent : MonoBehaviour {
	public static bool BeaconPath = false;
	public static bool Redirector = false; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (RedirectorisPlaced == true) {
			Redirector = true;
		}

		if (RedirectorisPlaced == false){
			Redirector = false;
		}
	
	}
}

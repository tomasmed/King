using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
    public double time;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (time > 0)
        { 
            time -= Time.deltaTime;
        }
	}
}

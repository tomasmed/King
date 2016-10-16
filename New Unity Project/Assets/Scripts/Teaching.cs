using UnityEngine;
using System.Collections;

public class Teaching : MonoBehaviour {
    public static Teaching S;
    public int jo;
    void Awake() {
        S = this;
    }
	// Use this for initialization
	void Start () {
        Teaching.S.jo += 1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {
    public GameObject Beacon;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
                Instantiate(Beacon, hit.point, transform.rotation);
        }
	}
}

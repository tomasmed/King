using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {
    public GameObject Beacon;
    public GameObject Floor;
    public int coins;
    public int beaconCost;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetMouseButtonDown(0))
        {
            if (coins >= beaconCost)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit) && (hit.collider.name.Equals(Floor.GetComponent<Collider>().name)))
                {
                    Instantiate(Beacon, hit.point, transform.rotation);
                    coins -= beaconCost;
                }
            }
        }
	}
}

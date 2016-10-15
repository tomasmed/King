using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {
    public GameObject Beacon;
    public int coins;
    public int BeaconCost;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetMouseButtonDown(0))
        {
            if (coins >= BeaconCost)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    Instantiate(Beacon, hit.point, transform.rotation);
                    coins -= BeaconCost;
                }
            }
        }
	}
}

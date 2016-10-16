using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour
{
    public GameObject Beacon;
    public GameObject Floor;
    public int coins;
    public int beaconCost;
    //public int redirectCost;
    //private bool placeBeacon;
    //private bool placeRedirect;
    //sound clip to place object
    //public AudioClip setObject;
    //sound clip when object can't be placed due to something in the way
    //public AudioClip noSetObjectBlock;
    //sound clip when object can't be placed because we're broke
    //public AudioClip noSetObjectBroke;

    void Start()
    {
        //placeBeacon = false;
        //placeRedirect = false;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(Input.GetKeyDown("1"))
        {
            placeBeacon = true;
            placeRedirect = false;
        }
        else if(Input.GetKeyDown("2"))
        {
            placeBeacon = true;
            placeRedirect = false;
        }
        */
        if (Input.GetMouseButtonDown(0))
        {
            if (coins >= beaconCost)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                //if RayCast Hits the ground
                if (Physics.Raycast(ray, out hit) && (hit.collider.name.Equals(Floor.GetComponent<Collider>().name)))
                {
                    Instantiate(Beacon, hit.point, transform.rotation);
                    coins -= beaconCost;
                    //AudioManager.Instance.PlaySound(setObject);
                }
                //if RayCast hits another object (can't place bc space)
                else if (hit.collider.name.Equals(Beacon.GetComponent<Collider>().name))
                {
                    //AudioManager.Instance.PlaySound(noSetObjectBlock);
                }
            }

		
            //if RayCast hits another object (can't place bc space)
            /* else if (raycaststuff)
            {
                AudioManager.Instance.PlaySound(noSetObjectBlock);
            }
            */
            //if RayCast hits ground, but not enough resources
            else
            {
                //AudioManager.Instance.PlaySound(noSetObjectBroke);
            }
        }
    }
}
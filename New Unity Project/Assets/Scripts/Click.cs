using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public GameObject Beacon;
    public GameObject Floor;
	public Text moneyGT;
    public int coins;
    public int beaconCost;
    //public int redirectCost;
    //private bool placeBeacon;
    //private bool placeRedirect;

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

					Controller.S.money -= beaconCost;

					//Text moneyGT = moneyGob.GetComponent <Text>(); 

					moneyGT.text = "Credits :" + Controller.S.money.ToString ();
	
                    AkSoundEngine.PostEvent("Play_Beacon", Beacon);
                    print("beaconsound");
                }
                //if RayCast hits another object (can't place bc space)
                else if (hit.collider.name.Equals(Beacon.GetComponent<Collider>().name))
                {

                }
            }
				
            //if RayCast hits ground, but not enough resources
            else
            {
                //AudioManager.Instance.PlaySound(noSetObjectBroke);
            }
        }
    }
}
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClickSwitch : MonoBehaviour
{
    public GameObject Beacon;
    public GameObject Redirect;
    public GameObject Floor;
    //public int coins;
    public int beaconCost;
    public int redirectCost;
    private bool placeBeacon;
    private bool placeRedirect;
    public Text moneyGT;

    void Start()
    {
        placeBeacon = false;
        placeRedirect = false;
    }

    // Update is called once per frame
    void Update()
    {
        checkInput();

        if (Input.GetMouseButtonDown(0))
        {
            if (!placeBeacon && !placeRedirect)
            {
                print("Please select beacon(1) or redirect(2)");
            }
            else if (placeBeacon)
            {
                addBeacon();
            }
            else if (placeRedirect)
            {
                addRedirect();
            }
        }
    }

    void checkInput()
    {
        if (Input.GetKeyDown("1"))
        {
            placeBeacon = true;
            placeRedirect = false;
        }
        else if (Input.GetKeyDown("2"))
        {
            placeBeacon = false;
            placeRedirect = true;
        }
    }

    void addBeacon()
    {
        if (Controller.S.money >= beaconCost)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            //if RayCast Hits the ground
            if (Physics.Raycast(ray, out hit) && (hit.collider.name.Equals(Floor.GetComponent<Collider>().name)))
            {
                Instantiate(Beacon, hit.point, transform.rotation);
                //coins -= beaconCost;
                Controller.S.money -= beaconCost;
                moneyGT.text = "Credits :" + Controller.S.money.ToString();
                AkSoundEngine.PostEvent("Play_Beacon", Beacon);
                print("beaconsound");
            }
            //if RayCast hits another object (can't place bc space)
            else if ((hit.collider.name.Equals(Beacon.GetComponent<Collider>().name)) || hit.collider.name.Equals(Redirect.GetComponent<Collider>().name))
            {
                //AudioManager.Instance.PlaySound(noSetObjectBlock);
            }
        }
        //if RayCast hits ground, but not enough resources
        else
        {
            //AudioManager.Instance.PlaySound(noSetObjectBroke);
        }
    }

    void addRedirect()
    {
        if (Controller.S.money >= redirectCost)
        {
			
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            //if RayCast Hits the ground
            if (Physics.Raycast(ray, out hit) && (hit.collider.name.Equals(Floor.GetComponent<Collider>().name)))
            {
				

				if (Controller.S.RedirectorisPlaced == true) {
					print ("we have a redirector");
					GameObject tmp = GameObject.Find ("Redirector(Clone)");
					Destroy (tmp);
				}
                Instantiate(Redirect, hit.point, transform.rotation);

			
				Controller.S.Redirectorpos = new Vector3 (hit.point.x,hit.point.y,hit.point.z);

                //coins -= redirectCost;
				Controller.S.money -= redirectCost; //redirectcost
                moneyGT.text = "Credits :" + Controller.S.money.ToString();
				print("placing redirector");
				Controller.S.RedirectorisPlaced = true; 

            }
            //if RayCast hits another object (can't place bc space)
            else if ((hit.collider.name.Equals(Beacon.GetComponent<Collider>().name)) || hit.collider.name.Equals(Redirect.GetComponent<Collider>().name))
            {
                //AudioManager.Instance.PlaySound(noSetObjectBlock);
            }
        }
        //if RayCast hits ground, but not enough resources
        else
        {
            //AudioManager.Instance.PlaySound(noSetObjectBroke);
        }
    }
}
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClickSwitch : MonoBehaviour
{
    public GameObject Beacon;
    public GameObject Redirect;
    public GameObject Floor;
	//public GameObject Redir;
    //public int coins;
    public int beaconCost;
    public int redirectCost;
    private bool placeBeacon;
    private bool placeRedirect;
    public Text moneyGT;
    public float hitOffsetBeacon;
    public float hitOffsetRedirector;
    public float moveSeconds;
    private GameObject toMove;

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
        //Beacon move
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
                //sets Vector3 transform to hit.point, offsets Y value by 'hitOffset' public varable
                Vector3 hitTransform = hit.point;
                hitTransform.y -= hitOffsetBeacon;
                //print(hit.point.y); //2.5
               // print(hitTransform.y); //-2.5

                //Hanna - changed hit.point to hitTransform
                Instantiate(Beacon, hitTransform, transform.rotation);
                //coins -= beaconCost;

				Controller.S.money = Controller.S.money - beaconCost;
                moneyGT.text = "Credits :" + Controller.S.money.ToString();
                AkSoundEngine.PostEvent("Play_Beacon", Beacon);
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
                //offsets spawn location by offset (positive)
                Vector3 hitTransform = hit.point;
                hitTransform.y += hitOffsetRedirector;
               // print(hit.point.y); //2.5
               // print(hitTransform.y); //-2.5

                if (Controller.S.RedirectorisPlaced == true) {
					//print ("we have a redirector");
					GameObject tmp = GameObject.Find ("Obelisk(Clone)");
					Destroy (tmp);
				}
                Instantiate(Redirect, hitTransform, transform.rotation);

				Controller.S.Redirectorpos = new Vector3 (hit.point.x,hit.point.y,hit.point.z);

                //coins -= redirectCost;
				Controller.S.money -= redirectCost; //redirectcost
                moneyGT.text = "Credits :" + Controller.S.money.ToString();
				//print("placing redirector");
                AkSoundEngine.PostEvent("Play_ReDirector", Redirect);
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
using UnityEngine;
using System.Collections;

public class Click : MonoBehaviour {
    public GameObject Beacon;
    // Use this for initialization
    //sound clip to place object
    public AudioClip setObject;
    //sound clip when object can't be placed due to something in the way
    public AudioClip noSetObjectBlock;
    //sound clip when object can't be placed because we're broke
    public AudioClip noSetObjectBroke;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            //if RayCast Hits the ground
            if (Physics.Raycast(ray, out hit))
            {
                Instantiate(Beacon, hit.point, transform.rotation);
                AudioManager.Instance.PlaySound(setObject);
            }
            //if RayCast hits another object (can't place bc space)
            /* else if (raycaststuff)
            {
                AudioManager.Instance.PlaySound(noSetObjectBlock);
            }
            */
            //if RayCast hits ground, but not enough resources
            /* else if (raycaststuff)
            {
                AudioManager.Instance.PlaySound(noSetObjectBroke);
            }
            */

        }
    }
}

using UnityEngine;
using System.Collections;

public class IntoBard : MonoBehaviour {


	public GameObject HomeposOb1;
	private NavMeshAgent agent;


	void OnTriggerEnter(Collider other){
		agent = GetComponent<NavMeshAgent>();
		if (other.tag == "Beacon") {
			agent.SetDestination(HomeposOb1.transform.position);
			print ("Agent is inside beacon");
			print ("redirecting to home");
		}

		if (other.tag == "HomeBase") {
			Debug.Log ("Agent is home : )");
			//agent.SetDestination(HomeposOb1.transform.position);
			
			Destroy(gameObject); ///code here to destory agent. 
		}

		if (other.tag == "Bard") {
			Debug.Log ("Agent is following");
			//agent.SetDestination(HomeposOb1.transform.position);
			print(other.transform.position);
			agent.Stop ();
		}




	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

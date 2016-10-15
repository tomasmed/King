using UnityEngine;
using System.Collections;

public class IntoBard : MonoBehaviour {


	public GameObject HomeposOb1;
	private NavMeshAgent agent;

	void OnTriggerStay(Collider other){
		agent = GetComponent<NavMeshAgent>();
		if (other.tag == "Bard") {
			Debug.Log ("Agent is inside bard");
			agent.SetDestination(HomeposOb1.transform.position);
		}

		if (other.tag == "HomeBase") {
			Debug.Log ("Agent is home : )");
			//agent.SetDestination(HomeposOb1.transform.position);
		}


	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class IntoBard : MonoBehaviour {


	public GameObject HomeposOb1;
	private NavMeshAgent agent;


	void OnTriggerEnter(Collider other){
		agent = GetComponent<NavMeshAgent>();
		if (other.tag == "Bard") {
			print ("Agent is inside bard");
			agent.SetDestination(HomeposOb1.transform.position);
			print ("redircting to home");

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

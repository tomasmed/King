using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IntoBard : MonoBehaviour {
	/// <summary>
	/// only for agents 
	/// </summary>

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
			//calls UI text to update it  
			GameObject scoreGob = GameObject.Find ("HighScore"); 
			Text scoreGT = scoreGob.GetComponent <Text>(); 
			Controller.S.score += 1; //call the global score
			scoreGT.text = "HumanCount: " + Controller.S.score.ToString ();
			Destroy(gameObject); //gameobject is Agent 
		}

		/*if (other.tag == "Bard") {
			Debug.Log ("Agent is following");
			//agent.SetDestination(HomeposOb1.transform.position);  //following code 
			print(other.transform.position);
			agent.Stop (); //stopping  
		}*/




	}

	void OnTriggerStay(Collider other){

		if (other.tag == "Bard") {
		Debug.Log ("Agent is following");
		//agent.SetDestination(HomeposOb1.transform.position);  //following code 
		print(other.transform.position);
		agent.Stop (); //stopping
		}
	}
		
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

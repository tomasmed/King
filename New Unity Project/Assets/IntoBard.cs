using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class IntoBard : MonoBehaviour {
	/// <summary>
	/// only for agents 
	/// </summary>
	//Agent theAgent;
	public GameObject HomeposOb1;
	private NavMeshAgent agent;
	public GameObject Beaconthing;

	public static bool BeaconPath = false;
	public static bool Redirector = false; 
	public static bool Redirecttouch = false;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (Controller.S.RedirectorisPlaced == true) {
			Redirector = true;
			/*if (BeaconPath == true && Redirecttouch == false) {
				print ("redirect is on");
				agent = GetComponent<NavMeshAgent> ();
				agent.SetDestination (Controller.S.Redirectorpos);
			}*/
		}


		if(Controller.S.RedirectorisPlaced == false){
			Redirector = false;
		}

	}

	private void Awake(){
		//BeaconPath = this.gameObject.GetComponentInParent<Agent>().BeaconPath;
	}
	void OnTriggerEnter(Collider other){
		agent = GetComponent<NavMeshAgent>();
		if (other.tag == "Beacon") {
			
			agent.SetDestination(HomeposOb1.transform.position);
			if(Redirector == true){
				agent.SetDestination(Controller.S.Redirectorpos);
			}
			BeaconPath = true;
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

		if (other.tag == "Redirector") {
			if(BeaconPath == true){
			Redirecttouch = true;
			//once agents hit the redirect they should move back to the castle.
			agent.SetDestination(HomeposOb1.transform.position);  //following code 
			print ("agent touched pillar, going home"); //stopping 
			
			
			}
		} 

		///if redirectbool is active 
		/// 	take agentNav and set to redirect node pos 
		// t

		///second redirect that sends to goal again 
		/// 
	
	}

	void OnTriggerStay(Collider other){

		if (other.tag == "Bard") {
		Debug.Log ("Agent is following");
		//agent.SetDestination(HomeposOb1.transform.position);  //following code 
		print(other.transform.position);
		agent.Stop (); //stopping
		}
	}
		


}

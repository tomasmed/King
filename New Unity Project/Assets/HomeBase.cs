using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using Uni

public class HomeBase : MonoBehaviour {


	public Text scoreGT;
	private int score;
	// Use this for initialization
	void Start () {
		score = 0;
		GameObject scoreGob = GameObject.Find ("HighScore"); 
		scoreGT = scoreGob.GetComponent <Text>(); 
		scoreGT.text = "HumanCount: 0";

	}



	// Update is called once per frame
	void Update () {



	}

	// updates UI Score when the agents enter in gate 
	void OnTriggerEnter(Collider other){
		if (other.tag == "Agent") {
			
			print ("agent is home! updating score"); 
			score += 1;
			scoreGT.text = "HumanCount: " + score.ToString();
			Destroy(other.gameObject); ///code here to destory agent. 
		}


	}

}

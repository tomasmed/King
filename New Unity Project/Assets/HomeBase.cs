﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using Uni

public class HomeBase : MonoBehaviour {


	public Text scoreGT;

	public Text moneyGT;

	// Use this for initialization
	void Start () {
		
		GameObject scoreGob = GameObject.Find ("HighScore"); 
		scoreGT = scoreGob.GetComponent <Text>(); 
		scoreGT.text = "Victim Count: 0"; 


		//GameObject moneyGob = GameObject.Find ("MoneyCount"); 
		//moneyGT = moneyGob.GetComponent <Text>(); 
		moneyGT.text = "Credits: " + Controller.S.money.ToString(); 
	}



	// Update is called once per frame
	void Update () {



	}

	// updates UI Score when the agents enter in gate 

}

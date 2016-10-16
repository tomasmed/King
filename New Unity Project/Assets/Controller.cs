using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Controller : MonoBehaviour {
	public static Controller S;
	public int score; 
	public int money; 
	public bool isRedirectorPlaced; 
	// Use tis for initialization
	public Text moneyGT;
	void Awake() {
		S = this;
	}

	void Start () {
		score = 0;
		//initialize money + score
		money = 6; 
		isRedirectorPlaced = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

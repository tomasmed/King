using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class MoveTo : MonoBehaviour {
	
	//public GameObject goalobject;
	//public static GameObject[] points;
	public Vector3[] vertices;
	private NavMeshAgent agent;

	public int xSize, ySize;

    public GameObject transformListOb;
	public List<GameObject> transformList = new List<GameObject>();



	//generates a list for each 
	private void Generate () {
		vertices = new Vector3[(xSize + 1) * (ySize + 1)];

		print (transformListOb.GetComponent<Scripty> ().tList.Count);

		//gridPoints = new Transform[(xSize + 1) * (ySize + 1)];
		for (int y = 0; y < transformListOb.GetComponent<Scripty> ().tList.Count; y++) {
			transformList.Add (transformListOb.GetComponent<Scripty> ().tList[y]);
		}
	}

	// Use this for initialization
	void Start () {

	///initializes abiment movement map 
	Generate();
	agent = GetComponent<NavMeshAgent>();


	/*goal.position =  new Vector3(Random.Range(-11,10), 1 , Random.Range (-11,10));

	print (goal.position);

	agent.SetDestination (goal.position);
	print ("agent");
	print (agent.destination);*/

	///First Movement
	GotoNextPoint();
	
	}
		

	void GotoNextPoint(){

		///error checking
		if (vertices.Length == 0)
			return;
		///sets the agent to go to a random position 


		//GameObject tmp = new GameObject ("tempNode");

        ///transform.position = vertices [Random.Range (10, 600)];

		agent.SetDestination(transformList[UnityEngine.Random.Range(10,600)].transform.position); 

		print ("agent");
		print(agent.destination);

	}


	// Update is called once per frame
	void Update (){

		///if the agent gets close, picks another position. 
		if( agent.remainingDistance < 0.5f)
			GotoNextPoint ();
			print(agent.destination);
		}
}

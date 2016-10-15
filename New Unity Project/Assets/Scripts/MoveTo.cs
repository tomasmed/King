using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour {
	
	//public GameObject goalobject;
	public static GameObject[] points;
	public static Vector3[] vertices;
	private NavMeshAgent agent;

	public int xSize, ySize;

	private void Awake () {
		Generate();
	}
		
	//public Transform[] gridPoints;

		
	//public Transform[] gridPoints;

	private void Generate () {
		vertices = new Vector3[(xSize + 1) * (ySize + 1)];
		//gridPoints = new Transform[(xSize + 1) * (ySize + 1)];
		for (int i = 0, y = 0; y <= ySize; y++) {
			for (int x = 0; x <= xSize; x++, i++) {
				vertices[i] = new Vector3(x-(xSize/2), 1, y-(ySize/2));
				//gridPoints[i].position = new Vector3(x-(xSize/2), 1, y-(ySize/2));
			}
		}
	}

	// Use this for initialization
	void Start () {

	///initializes abiment movement map 

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


		GameObject tmp = new GameObject ("tempNode");

		tmp.transform.position = vertices [Random.Range (10, 600)];

		print (tmp.transform.position);
		print("agent");
		agent.destination = tmp.transform.position;
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

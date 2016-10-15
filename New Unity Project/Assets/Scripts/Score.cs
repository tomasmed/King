using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
    private int capturedAgents;
    public GameObject Agent;
    void OnCollisionEnter(GameObject Agent)
    {
        Collider col = Agent.GetComponent<Collider>();
        if (col.gameObject.tag == "Agent")
        {
            capturedAgents += 1;
            Destroy(Agent);
        }
    }
    // Use this for initialization
    void Start () {
        capturedAgents = 0;
	}
	
	// Update is called once per frame
	void Update () {
        OnCollisionEnter(Agent);
        print(capturedAgents);
	}
}




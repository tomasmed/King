using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement;

public class Play_again : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("p"))
        {
            SceneManager.LoadScene("Main_Tomas");
        }

    }
}

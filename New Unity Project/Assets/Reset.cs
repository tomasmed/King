using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown("p"))
        {
            SceneManager.LoadScene("Main_Tomas");
        }


        if (Controller.S.score == 5)
        {
            print("win");
            SceneManager.LoadScene("WIN");
        }

    }



    

}

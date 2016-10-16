using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public GameObject TimerGob;
	// Use this for initialization
	void Start () {
        Text timerGT = TimerGob.GetComponent<Text>();
        timerGT.text = "Time Left: 60";
    }
	
	// Update is called once per frame
	void Update () {
        if (Controller.S.timer > 0)
        { 
            Controller.S.timer -= Time.deltaTime;
            Text timerGT = TimerGob.GetComponent<Text>();
            timerGT.text = "Time Left: " + ((int)Controller.S.timer);
        }
        else
        {
            //Move to new scene
        }
    }
}

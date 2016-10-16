using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TutorialSceneSwitch : MonoBehaviour {

    public Animation agent;
    public Animation sphere;
    public Animation enemy;
    public AnimationClip fadeColorAnimationClip;
    public Animator animColorFade;

    // Use this for initialization
    void Start () {
        //input playercontroller script here
        //Gameobject.Find("objectthathasthescript").GetComponent(thescript).enabled = false;
        
        StartCoroutine(Scheduler());
    }

    IEnumerator Scheduler()
    {
        print(Time.time);
        yield return new WaitForSeconds(18);
        print(Time.time);
        SceneManager.LoadScene(2, LoadSceneMode.Single);

        //Use invoke to delay calling of LoadDelayed by half the length of fadeColorAnimationClip
        Invoke("LoadDelayed", fadeColorAnimationClip.length * .5f);
        

    }

    // Update is called once per frame
    void Update () {
	
	}
}

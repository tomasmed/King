using UnityEngine;
using System.Collections;

public class RedirectorMove : MonoBehaviour
{

    public Transform beaconTrans;
    public float transOffset;
    public float speed = 1.0f;
    private float startTime;
    private float journeyLength;
    private Vector3 target;

    // Use this for initialization
    void Start()
    {
        beaconTrans = this.gameObject.transform;
        target = new Vector3(beaconTrans.position.x, beaconTrans.position.y - transOffset,
            beaconTrans.position.z);
        startTime = Time.time;
        journeyLength = Vector3.Distance(beaconTrans.position, target);
    }

    // Update is called once per frame
    void Update()
    {
        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        transform.position = Vector3.Lerp(beaconTrans.position, target, fracJourney);
    }
}

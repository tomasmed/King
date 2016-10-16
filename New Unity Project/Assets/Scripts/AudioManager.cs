using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

    public static AudioManager Instance;
    public GameObject audioSourcePrefab;
    public float randMin = -0.1f;
    public float randMax = 0.2f;

	void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySound(AudioClip clip)
    {
        //stuff
    }

    public void PlaySound(AudioClip clip, float pitch, float volume, float spatialBlend = 1f)
    {
        //instantiates audiosource locally
        AudioSource myAudioSource = Instantiate(audioSourcePrefab).GetComponent<AudioSource>();
        //pitch value of prefab is set to input pitch + variation
        float randomPitch = Random.Range(randMin, randMax);
        myAudioSource.pitch = pitch + randomPitch;
        //set volume
        myAudioSource.volume = volume;
        //same process for spatialblend
        myAudioSource.spatialBlend = spatialBlend;
        myAudioSource.clip = clip;
        myAudioSource.Play();

        Destroy(myAudioSource, myAudioSource.clip.length);
    }
}

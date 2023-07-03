using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance = null;
    public AudioClip flapAudio;
    public AudioSource audioSource;
    public AudioClip endGameAudio;
    public AudioClip ScoreAudio;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    public void PlayFlapBird()
    {
        audioSource.PlayOneShot(flapAudio);
    }
    public void PlayEndGameAudio()
    {
        audioSource.PlayOneShot(endGameAudio);
    }
    public void PlayAudioScore()
    {
        audioSource.PlayOneShot(ScoreAudio);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicaContinua : MonoBehaviour
{
    public AudioClip Overworld;
    public AudioClip Boss;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if(audioSource.isPlaying)
        {
            audioSource.Stop();
        }
        audioSource.clip = Overworld;
        audioSource.Play();

        if(audioSource.isPlaying)
        {
            audioSource.Stop();
        }
        audioSource.clip = Boss;
        audioSource.Play();
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay_applaud : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        Invoke("PlayAudio", 8f);
    }

    void PlayAudio()
    {
        audioSource.Play();
    }
}

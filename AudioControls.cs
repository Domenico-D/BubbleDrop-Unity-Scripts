using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControls : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip music;

    // Start is called before the first frame update
    void Start()
    {

        audio = GetComponent<AudioSource>();
        audio.clip = music;
        audio.volume = PlayerPrefs.GetFloat("MusicVolume");


    }
    private void Update()
    {
        audio.volume = PlayerPrefs.GetFloat("MusicVolume");
    }



}

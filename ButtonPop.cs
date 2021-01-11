using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPop : MonoBehaviour
{
    public AudioSource button;
    public AudioClip pop;

    // Start is called before the first frame update
    void Start()
    {

        button = GetComponent<AudioSource>();
        button.clip = pop;
        button.volume = PlayerPrefs.GetFloat("MasterVolume");
    }

    // Update is called once per frame
    void Update()
    {
        button.volume = PlayerPrefs.GetFloat("MasterVolume");


    }

    public void buttonPop()
    {
        button.Play();
    }
}

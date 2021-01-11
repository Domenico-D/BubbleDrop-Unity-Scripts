using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{

    public Slider master;
    public Slider music;

    public Button muteMasterBtn;
    public Button muteMusicBtn;

    public Sprite mutedMusic;
    public Sprite unMutedMusic;
    public Sprite mutedMaster;
    public Sprite unMutedMaster;

    private void Start()
    {
        master.value = PlayerPrefs.GetFloat("MasterVolume", 0.5f);
        music.value = PlayerPrefs.GetFloat("MusicVolume", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("MasterVolume", master.value);

        if(master.value < music.value)
        {
            PlayerPrefs.SetFloat("MusicVolume", master.value);
        }
        else
        {
            PlayerPrefs.SetFloat("MusicVolume", music.value);
        }
        //Change picture of button if muted
        if(music.value == 0.0f)
        {
            muteMusicBtn.image.sprite = mutedMusic;

        }
        else
        {
            muteMusicBtn.image.sprite = unMutedMusic;
        }
        //Change pictur eof button if muted
        if (master.value == 0.0f)
        {
            muteMasterBtn.image.sprite = mutedMaster;

        }
        else
        {
            muteMasterBtn.image.sprite = unMutedMaster;
        }
    }

    public void muteMusic()
    {
        music.value = 0.0f;
        PlayerPrefs.SetFloat("MusicVolume", 0.0f);
    }

    public void muteMaster()
    {
        master.value = 0.0f;
        PlayerPrefs.SetFloat("MasterVolume", 0.0f);
        music.value = 0.0f;
        PlayerPrefs.SetFloat("MusicVolume", 0.0f);
    }
}

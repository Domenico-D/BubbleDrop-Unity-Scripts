using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{

    public void playGame()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);

       
    }

    public void openShop()
    {
        SceneManager.LoadScene("Shop", LoadSceneMode.Single);
    }

    public void openSettings()
    {
        SceneManager.LoadScene("Settings", LoadSceneMode.Single);
    }

  

    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
        PlayerPrefs.SetInt("ContinueScore", 0);
    }
}

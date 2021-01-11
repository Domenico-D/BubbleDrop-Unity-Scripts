using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class WallCollision : MonoBehaviour
{ 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("MainCamera") || collision.tag.Equals("Platform"))
        {
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);   
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") + CoinScore.scoreValue);
            PlayerPrefs.SetInt("ContinueScore", Score.scoreValue);
            Score.scoreValue = 0;
            //Reset amount of coins allowed so they can still spawn
            SpawnCoins.numCoins = 0;
            /*
            if (Advertisement.IsReady("video"))
            {
                Advertisement.Show("video");
            }
            */
        }

    }
}

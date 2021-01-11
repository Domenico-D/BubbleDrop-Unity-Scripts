using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int scoreValue = 0;
    public Text score;

    private void Start()
    {
        if (Difficulty.easyScore)
        {
            score.text = scoreValue.ToString();
            PlayerPrefs.SetInt("Score", scoreValue);
            if (PlayerPrefs.GetInt("Score", 0) > PlayerPrefs.GetInt("HighScore_Easy", 0))
            {
                PlayerPrefs.SetInt("HighScore_Easy", PlayerPrefs.GetInt("Score", 0));
            }
        }
        else if (Difficulty.mediumScore)
        {
            score.text = scoreValue.ToString();
            PlayerPrefs.SetInt("Score", scoreValue);
            if (PlayerPrefs.GetInt("Score", 0) > PlayerPrefs.GetInt("HighScore_Medium", 0))
            {
                PlayerPrefs.SetInt("HighScore_Medium", PlayerPrefs.GetInt("Score", 0));
            }
        }
        else if (Difficulty.hardScore)
        {
            score.text = scoreValue.ToString();
            PlayerPrefs.SetInt("Score", scoreValue);
            if (PlayerPrefs.GetInt("Score", 0) > PlayerPrefs.GetInt("HighScore_Hard", 0))
            {
                PlayerPrefs.SetInt("HighScore_Hard", PlayerPrefs.GetInt("Score", 0));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Difficulty.easyScore)
        {
            score.text = scoreValue.ToString();
            PlayerPrefs.SetInt("Score", scoreValue);
            if (PlayerPrefs.GetInt("Score", 0) > PlayerPrefs.GetInt("HighScore_Easy", 0))
            {
                PlayerPrefs.SetInt("HighScore_Easy", PlayerPrefs.GetInt("Score", 0));
            }
        }
        else if (Difficulty.mediumScore)
        {
            score.text = scoreValue.ToString();
            PlayerPrefs.SetInt("Score", scoreValue);
            if (PlayerPrefs.GetInt("Score", 0) > PlayerPrefs.GetInt("HighScore_Medium", 0))
            {
                PlayerPrefs.SetInt("HighScore_Medium", PlayerPrefs.GetInt("Score", 0));
            }
        }
        else if (Difficulty.hardScore)
        {
            score.text = scoreValue.ToString();
            PlayerPrefs.SetInt("Score", scoreValue);
            if (PlayerPrefs.GetInt("Score", 0) > PlayerPrefs.GetInt("HighScore_Hard", 0))
            {
                PlayerPrefs.SetInt("HighScore_Hard", PlayerPrefs.GetInt("Score", 0));
            }
        }

        
       
    
    }
}

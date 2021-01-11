using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text highScore;

    // Start is called before the first frame update
    void Start()
    {
        //based on what difficulty is chosen display the highscore of that difficulty
        if (Difficulty.easyScore)
        {
            highScore.text = PlayerPrefs.GetInt("HighScore_Easy", 0).ToString();
        }
        else if (Difficulty.mediumScore)
        {
            highScore.text = PlayerPrefs.GetInt("HighScore_Medium", 0).ToString();
        }
        else if (Difficulty.hardScore)
        {
            highScore.text = PlayerPrefs.GetInt("HighScore_Hard", 0).ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //based on what difficulty is chosen display the highscore of that difficulty
        if (Difficulty.easyScore)
        {
            highScore.text = PlayerPrefs.GetInt("HighScore_Easy", 0).ToString();
        }
        else if (Difficulty.mediumScore)
        {
            highScore.text = PlayerPrefs.GetInt("HighScore_Medium", 0).ToString();
        }
        else if (Difficulty.hardScore)
        {
            highScore.text = PlayerPrefs.GetInt("HighScore_Hard", 0).ToString();
        }
    }
}

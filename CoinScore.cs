using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScore : MonoBehaviour
{

    public static int scoreValue;
    public Text score;

    private void Start()
    {
        scoreValue = 0;
        score.text = scoreValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        score.text = scoreValue.ToString();
 

    }
}

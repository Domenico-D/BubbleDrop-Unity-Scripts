using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueScore : MonoBehaviour
{
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        score.text = PlayerPrefs.GetInt("ContinueScore").ToString();
    }

   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalCoins : MonoBehaviour
{
    public Text coins;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coins.text = PlayerPrefs.GetInt("Coins", 0).ToString();
    }
}

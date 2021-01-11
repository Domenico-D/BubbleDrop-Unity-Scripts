using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cosmetics : MonoBehaviour
{
    public SpriteRenderer player;
    public Sprite[] balls;
    

    // Start is called before the first frame update
    void Start()
    {

        player.sprite = balls[PlayerPrefs.GetInt("Ball")];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

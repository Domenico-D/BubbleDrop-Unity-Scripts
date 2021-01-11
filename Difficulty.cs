using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Difficulty : MonoBehaviour
{

    public Toggle easy;
    public Toggle medium;
    public Toggle hard;
    public static bool easyScore;
    public static bool mediumScore;
    public static bool hardScore;

    // Start is called before the first frame update
    void Start()
    {
        if (easy.isOn)
        {
            //Update booleans to determine which highscore will be shown on home screen
            easyScore = true;
            mediumScore = false;
            hardScore = false;
            //Change the respawn speed of the platforms for easy difficulty and ball movement
            SpawnPlatform.respawn = 3f;
           
        }
        else if (medium.isOn)
        {
            //Update booleans to determine which highscore will be shown on home screen
            easyScore = false;
            mediumScore = true;
            hardScore = false;
            //Change the respawn speed of the platforms for medium difficulty and ball movement
            SpawnPlatform.respawn = 2.25f;
            
        }
        else if (hard.isOn)
        {
            //Update booleans to determine which highscore will be shown on home screen
            easyScore = false;
            mediumScore = false;
            hardScore = true;
            //Change the respawn speed of the platforms for hard difficulty and ball movement
            SpawnPlatform.respawn = 1.8f;
            
        }

        
    }

    void Update()
    {
        if (easy.isOn)
        {
            //Update booleans to determine which highscore will be shown on home screen
            easyScore = true;
            mediumScore = false;
            hardScore = false;
            //Change the respawn speed of the platforms for easy difficulty and ball movement
            SpawnPlatform.respawn = 3f;
            
        }
        else if (medium.isOn)
        {
            //Update booleans to determine which highscore will be shown on home screen
            easyScore = false;
            mediumScore = true;
            hardScore = false;
            //Change the respawn speed of the platforms for medium difficulty and ball movement
            SpawnPlatform.respawn = 2.25f;
           
        }
        else if (hard.isOn)
        {
            //Update booleans to determine which highscore will be shown on home screen
            easyScore = false;
            mediumScore = false;
            hardScore = true;
            //Change the respawn speed of the platforms for hard difficulty and ball movement
            SpawnPlatform.respawn = 1.8f;
           
        }

    }
}

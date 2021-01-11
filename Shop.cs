using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{

    private int ball1 = 0;
    private int ball2_3 = 0;
    private int ball4 = 0;
    private int ball5 = 0;

    public Button buy0;
    public Button buy1;
    public Button buy2;
    public Button buy3;
    public Button buy4;
    public Button buy5;
    
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void defaultBall()
    {

        PlayerPrefs.SetInt("Ball", 0);
        PlayerPrefs.SetInt("ball0", 1);
        buy0.interactable = false;
        buy1.interactable = true;
        buy2.interactable = true;
        buy3.interactable = true;
        buy4.interactable = true;
        buy5.interactable = true;

    }

    public void buyBall1()
    {
        if (PlayerPrefs.GetInt("ball1") == 1)
        {
            PlayerPrefs.SetInt("Ball", 1);
            buy0.interactable = true;
            buy1.interactable = false;
            buy2.interactable = true;
            buy3.interactable = true;
            buy4.interactable = true;
            buy5.interactable = true;
        }
        else if(PlayerPrefs.GetInt("Coins") >= ball1)
        {
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - ball1);
            PlayerPrefs.SetInt("ball1", 1);
            PlayerPrefs.SetInt("Ball", 1);
            buy0.interactable = true;
            buy1.interactable = false;
            buy2.interactable = true;
            buy3.interactable = true;
            buy4.interactable = true;
            buy5.interactable = true;
        }
        
    }

    public void buyBall2()
    {
        if (PlayerPrefs.GetInt("ball2") == 1)
        {
            PlayerPrefs.SetInt("Ball", 2);
            buy0.interactable = true;
            buy1.interactable = true;
            buy2.interactable = false;
            buy3.interactable = true;
            buy4.interactable = true;
            buy5.interactable = true;
        }
        else if (PlayerPrefs.GetInt("Coins") >= ball2_3)
        {
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - ball2_3);
      
            PlayerPrefs.SetInt("ball2", 1);
            PlayerPrefs.SetInt("Ball", 2);
            buy0.interactable = true;
            buy1.interactable = true;
            buy2.interactable = false;
            buy3.interactable = true;
            buy4.interactable = true;
            buy5.interactable = true;
        }
    }

    public void buyBall3()
    {
        if (PlayerPrefs.GetInt("ball3") == 1)
        {
            PlayerPrefs.SetInt("Ball", 3);
            buy0.interactable = true;
            buy1.interactable = true;
            buy2.interactable = true;
            buy3.interactable = false;
            buy4.interactable = true;
            buy5.interactable = true;
        }
        else if (PlayerPrefs.GetInt("Coins") >= ball2_3)
        {
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - ball2_3);
          
            PlayerPrefs.SetInt("ball3", 1);
            PlayerPrefs.SetInt("Ball", 3);
            buy0.interactable = true;
            buy1.interactable = true;
            buy2.interactable = true;
            buy3.interactable = false;
            buy4.interactable = true;
            buy5.interactable = true;
        }
    }

    public void buyBall4()
    {
        if (PlayerPrefs.GetInt("ball4") == 1)
        {
            PlayerPrefs.SetInt("Ball", 4);
            buy0.interactable = true;
            buy1.interactable = true;
            buy2.interactable = true;
            buy3.interactable = true;
            buy4.interactable = false;
            buy5.interactable = true;
        }
        else if (PlayerPrefs.GetInt("Coins") >= ball4)
        {
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - ball4);
            PlayerPrefs.SetInt("ball4", 1);
            PlayerPrefs.SetInt("Ball", 4);
            buy0.interactable = true;
            buy1.interactable = true;
            buy2.interactable = true;
            buy3.interactable = true;
            buy4.interactable = false;
            buy5.interactable = true;
        }
    }

    public void buyBall5()
    {
        if (PlayerPrefs.GetInt("ball5") == 1)
        {
            PlayerPrefs.SetInt("Ball", 5);
            buy0.interactable = true;
            buy1.interactable = true;
            buy2.interactable = true;
            buy3.interactable = true;
            buy4.interactable = true;
            buy5.interactable = false;
        }
        if (PlayerPrefs.GetInt("Coins") >= ball5)
        {
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - ball5);
            PlayerPrefs.SetInt("ball5", 1);
            PlayerPrefs.SetInt("Ball", 5);
            buy0.interactable = true;
            buy1.interactable = true;
            buy2.interactable = true;
            buy3.interactable = true;
            buy4.interactable = true;
            buy5.interactable = false;
        }
    }


}

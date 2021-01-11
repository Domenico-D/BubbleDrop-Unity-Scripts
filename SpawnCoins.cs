using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    public GameObject coinPrefab;
    public float respawnTime = 5f;
    private Vector2 screenBounds;
    private bool canSpawn;
    public static int numCoins;

    // Start is called before the first frame update
    void Start()
    {
        canSpawn = true;
        //Get size of screen and beging platform spawining
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(coins());

    }

    //spawn platform based on platform prefab in two locations
    private void spawnCoin()
    {
        //only spawn coins if there are no coins and player isnt already on top of them
        if (canSpawn && numCoins < 1)
        {
            GameObject a = Instantiate(coinPrefab) as GameObject;
            if (Random.Range(0.0f, 1.0f) > 0.5)
            {
                a.transform.position = new Vector2(-1.7f, 2);

            }
            else
            {
                a.transform.position = new Vector2(1.7f, 2);

            }
            //increase amount of coins counter so that only 1 coin may appear at a time
            numCoins++;
        }
        

    }




    //consistently spawn platforms based on the respawn times
    IEnumerator coins()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnCoin();

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player") || collision.tag.Equals("Coin"))
        {
            canSpawn = false;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player") || collision.tag.Equals("Coin"))
        {
            canSpawn = true;
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player") || collision.tag.Equals("Coin"))
        {
            canSpawn = false;
        }
    }


}

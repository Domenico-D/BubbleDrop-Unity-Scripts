using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {

            Destroy(this.gameObject);
            //reset number of coins allowed on the screen
            SpawnCoins.numCoins = 0;
            CoinScore.scoreValue++;
        }

    }
}

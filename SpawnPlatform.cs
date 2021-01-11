using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    public GameObject platformPrefab;
    public float respawnTime;
    //public static float respawnTime = 1f;
    private Vector2 screenBounds;
    public static float respawn;


    // Start is called before the first frame update
    void Start()
    {

        respawnTime = respawn;
        //Get size of screen and beging platform spawining
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(platforms());
    }

    //spawn platform based on platform prefab in two locations
    private void spawnPlatform()
    {
        GameObject a = Instantiate(platformPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(-screenBounds.x / 2 , screenBounds.x / 2), screenBounds.y);
     
    }




    //consistently spawn platforms based on the respawn times
    IEnumerator platforms()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnPlatform();
        }
    }
}

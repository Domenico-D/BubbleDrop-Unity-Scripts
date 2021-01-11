using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour
{

    string gameId = "3741457";
    string placementId = "banner";
    bool testMode = true;



    IEnumerator Start()
    {
        Advertisement.Initialize(gameId, testMode);

        while (!Advertisement.IsReady(placementId))
        {
            yield return null;
            
        }
       

        Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
        Advertisement.Banner.Show(placementId);


    }

}

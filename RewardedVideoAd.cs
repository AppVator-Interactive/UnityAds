using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.Monetization;
using UnityEngine.UI;

public class RewardedVideoAd : MonoBehaviour
{

    private string game_id = "";
    private static string rewardedVideo_ad = "";

    private static RewardedVideoAd instance;

    void Start()
    {
        Monetization.Initialize(game_id, true);
        instance = this;
    }

    public static void ShowAd()
    {
        instance.StartCoroutine(instance.WaitForAd());
    }

    IEnumerator WaitForAd()
    {
        while (!Monetization.IsReady(rewardedVideo_ad))
        {
            yield return null;
        }

        ShowAdPlacementContent ad = null;
        ad = Monetization.GetPlacementContent(rewardedVideo_ad) as ShowAdPlacementContent;

        if (ad != null)
        {
            ad.Show(AdFinished);
        }
    }

    void AdFinished(UnityEngine.Monetization.ShowResult result)
    {
        if (result == UnityEngine.Monetization.ShowResult.Finished)
        {
            // REWARD HERE
        }
        else
        {
            // VIDEO WAS SKIPPPED
            Debug.Log("Skipped");
        }
    }
}

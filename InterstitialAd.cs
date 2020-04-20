using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class InterstitialAd : MonoBehaviour
{

    private string game_id = "";
    private static string video_ad = "";

    void Start()
    {
        Advertisement.Initialize(game_id, true);
    }

    public static void ShowAd()
    {
        if (Advertisement.IsReady(video_ad))
        {
            Advertisement.Show(video_ad);
            Advertisement.Banner.Hide();
        }
    }

}

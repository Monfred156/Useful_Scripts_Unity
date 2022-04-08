using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour, IUnityAdsListener
{
    public GameManager gameManager;
    
#if UNITY_IOS
    private string gameID = ""; //TODO: Update
    private bool isIOS = true;
#else
    private string gameID = ""; //TODO: Update
    private bool isIOS = false;
#endif

    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(gameID);
        Advertisement.AddListener(this);
    }

    public void PlayRewardedVideo()
    {
        if (isIOS)
        {
        }
        else
        {
            if (Advertisement.IsReady("Rewarded_Android")) //TODO: Update with your ad ID
            {
                Advertisement.Show("Rewarded_Android"); //TODO: Update with your ad ID
            }
            else
            {
                Debug.Log("Add reward not ready");
            }
        }
    }
    public void OnUnityAdsReady(string placementId)
    {
    }
    public void OnUnityAdsDidError(string message)
    {
        Debug.Log("Ads error");
    }
    public void OnUnityAdsDidStart(string placementId)
    {
        Debug.Log("Ads start");
    }
    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (placementId == "Rewarded_Android" && showResult == ShowResult.Finished) //TODO: Update with your ad ID
        {
        }
    }
}

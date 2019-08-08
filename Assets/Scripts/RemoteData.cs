﻿using System.Collections;
using UnityEngine;
using UnityEngine.Networking;


public class RemoteData : MonoBehaviour
{

    private int gameSlideNumber = 0;
    private int gameRotation = 0;

    void Start()
    {
        StartCoroutine("GetRequest");
    }


    IEnumerator GetRequest()
    {
        while (true)
        {
            using (UnityWebRequest webRequest = UnityWebRequest.Get("https://api.myjson.com/bins/jub2l"))
            {

                yield return webRequest.SendWebRequest();

                if (webRequest.isNetworkError)
                {
                    Debug.Log("Error: " + webRequest.error);
                }
                else
                {
                    //Debug.Log(":\nReceived: " + webRequest.downloadHandler.text);

                    SensorTileJson webVars = JsonUtility.FromJson<SensorTileJson>(webRequest.downloadHandler.text);


                    //Debug.Log("XValue" + webVars.slideNumber);
                    // Debug.Log("YValue" + webVars.slideBrightness);



                    if (webVars.slideNumber > gameSlideNumber)
                    {
                        Debug.Log("swiped forward!"); 
                        EventManager.TriggerEvent("SwipeFoward");
                    }

                    else if (webVars.slideNumber < gameSlideNumber)
                    {    
                         Debug.Log("swiped backward!"); 
                         EventManager.TriggerEvent("SwipeBackward");

                    }

                    gameSlideNumber = webVars.slideNumber;
                    Debug.Log(gameSlideNumber);

                    if (webVars.Rotation != gameRotation) {
                        Debug.Log("rotation called");
                        EventManager.TriggerEvent("Rotate");
                    }



                }
            }
        }
    }
}

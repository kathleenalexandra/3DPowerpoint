using System.Collections;
using UnityEngine;
using UnityEngine.Networking;


    public class RemoteData : MonoBehaviour
    { 

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


                         Debug.Log("XValue" + webVars.slideNumber);
                         Debug.Log("YValue" + webVars.slideBrightness);
                  

                    }
                }
            }
        }
    }

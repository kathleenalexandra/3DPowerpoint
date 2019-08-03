using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

namespace ReinforcementUI
{
    public class InternalRemoteUI : MonoBehaviour
    { 
        

        void Start()
        {
            

        }




        IEnumerator GetRequest(string uri)
        {
            while (true)
            {
                using (UnityWebRequest webRequest = UnityWebRequest.Get("https://api.myjson.com/bins/jub2l"))
                {
                    // Request and wait for the desired page.
                    yield return webRequest.SendWebRequest();

                    /*  string[] pages = uri.Split('/');
                      int page = pages.Length - 1; */

                    if (webRequest.isNetworkError)
                    {
                        Debug.Log("Error: " + webRequest.error);
                    }
                    else
                    {
                        //Debug.Log(":\nReceived: " + webRequest.downloadHandler.text);

                        RemoteUIData webVars = JsonUtility.FromJson<RemoteUIData>(webRequest.downloadHandler.text);

                        //CanvasPositionerConstants.informationZoneSize = webVars.informationZoneSize;
                        //anvasPositionerConstants.educationZoneSize = webVars.educationZoneSize;

                          Debug.Log("InfoZone Sz" + webVars.informationZoneSize);
                          Debug.Log("EducationZone Sz" + webVars.educationZoneSize); 

                    }
                }
            }
        }
    }
}
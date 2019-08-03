using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugKeyboardListener : MonoBehaviour
{
    

    void Update()
    {

        if (Input.anyKeyDown)
        {
        	Debug.Log("Key pressed" +  Input.inputString.ToString()); 

            switch (Input.inputString)
            {
                case "1":
                    EventManager.TriggerEvent("SwipeFoward");
                    break;
                case "2":
                    EventManager.TriggerEvent("SwipeBackward");
                    break;
                case "3":
                    EventManager.TriggerEvent("Rotate");
                    break;
                case "4":
                    EventManager.TriggerEvent("Spin");
                    break;
            default:
                Debug.Log("NAN");
                break;
            }
        }
    }

}

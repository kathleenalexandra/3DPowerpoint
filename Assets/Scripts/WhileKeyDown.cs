using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class WhileKeyDown : MonoBehaviour
{
	

    void Update()
    {
        if (Input.GetKey("up"))
        {
            print("up arrow key is held down");
            transform.Rotate(0,20*Time.deltaTime,0);
        }

        if (Input.GetKey("down"))
        {
            print("down arrow key is held down");
        }
    }

}

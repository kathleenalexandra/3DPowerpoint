﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class LerpColor : MonoBehaviour
    {
        Color lerpedColor = Color.white;

        void Update()
        {
            lerpedColor = Color.Lerp(Color.white, Color.black, Mathf.PingPong(Time.time, 1));
        }
    }



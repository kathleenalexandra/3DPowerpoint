﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
 
 
 
 void Update()
 {
    transform.Rotate(0,20*Time.deltaTime,0);
 }

}

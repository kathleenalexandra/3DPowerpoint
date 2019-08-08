using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RotateObject : MonoBehaviour
{
 
[SerializeField]
private GameObject slide; 

 private UnityAction rotateSlide;



void Start() {
	 rotateSlide = new UnityAction (RotateSlide);
     EventManager.StartListening ("Rotate", rotateSlide);
}



void RotateSlide() {

	Debug.Log("rotate was called"); 

	if (slide.gameObject.transform.position.y == 0) {
 		transform.Rotate(0,30,0);
 	} else {
 		return;  
 	} 


}


 
 
 void Update()
 {
 	
 	
    
 }

}

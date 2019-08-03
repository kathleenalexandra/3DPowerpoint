using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System.Linq;

public class PresentationHandler : MonoBehaviour
{

    [SerializeField]
    public  GameObject Slides, Slide1;

    public List<Transform> pSlides;

    private UnityAction swipedForward, swipedBackward;

    float SlideOffset = 11f;

    public Quaternion slidePos; 


    // Start is called before the first frame update
    void Start()
    {

        //Debug.Log("Master rotation is" + Slide1.transform.rotation); 

        slidePos = Slide1.transform.rotation; 


        swipedForward = new UnityAction (NextSlide);
        EventManager.StartListening ("SwipeFoward", swipedForward);

        swipedBackward = new UnityAction (PreviousSlide);
        EventManager.StartListening ("SwipeBackward", swipedBackward);

        /*foreach (Transform slide in Slides.transform)
        {
            pSlides.Add(slide.transform);
            pSlides.IndexOf(slide);
            Debug.Log(slide.ToString());
            slide.transform.position = new Vector3(slide.transform.position.x,slide.transform.position.y+SlideOffset,slide.transform.position.z);
        } */



        // star.transform.position  = new Vector2(Screen.width / 2, Screen.height / 2);
        //  startingScale = star.transform.localScale;

    }




    public void NextSlide()
    {
        foreach (Transform slide in Slides.transform)
        {
            pSlides.Add(slide.transform);
            pSlides.IndexOf(slide);
            Debug.Log(slide.ToString());
            Debug.Log("Slide rotation" + slide.rotation);
            slide.rotation = slidePos;  
            slide.transform.position = new Vector3(slide.transform.position.x, slide.transform.position.y + SlideOffset, slide.transform.position.z);
        }

    }



    public void PreviousSlide()
    {
        foreach (Transform slide in Slides.transform)
        {
            pSlides.Add(slide.transform);
            pSlides.IndexOf(slide);
            Debug.Log(slide.ToString());
            slide.rotation = slidePos;
            slide.transform.position = new Vector3(slide.transform.position.x, slide.transform.position.y - SlideOffset, slide.transform.position.z);
        }

    }





    // Update is called once per frame
    void Update()
    {

    }
}

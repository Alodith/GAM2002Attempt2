using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByTouch : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        //touchcount > 0 asks if there are anytouches at all.
        //GetTouch(0) gets the info of the first touch on the screen.
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            transform.position = touchPosition;

        }
        
    }
}

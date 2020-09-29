using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObjectLeft : MonoBehaviour
{
    public bool canBePressed;

    public Swipe swipeControls;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (swipeControls.SwipeLeft)
        {
            if (canBePressed)
            {
                gameObject.SetActive(false);
                //Will also put damage here 
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Activator")
        {
            canBePressed = true; 
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeMove : MonoBehaviour
{
    public Swipe swipeControls;
    public Transform player;
    public bool IsRightWall;
    public bool IsLeftWall;
    // Start is called before the first frame update
    void Start()
    {
        IsRightWall = false;
        IsLeftWall = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (swipeControls.SwipeLeft && IsLeftWall == false)
            transform.position += Vector3.left * 1f;
        if (swipeControls.SwipeRight && IsRightWall == false)
            transform.position += Vector3.right * 1f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RightSide")
        {
            IsRightWall = true;
        }
        else if (other.gameObject.tag == "LeftSide")
        {
            IsLeftWall = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "RightSide")
        {
            IsRightWall = false;
        }
        else if (other.gameObject.tag == "LeftSide")
        {
            IsLeftWall = false;
        }
    }
}

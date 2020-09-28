    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeTest : MonoBehaviour
{
    public Swipe swipeControls;
    public Transform player;
    private Vector3 desiredPosition;

    // Update is called once per frame
    private void Update()
    {
        if (swipeControls.SwipeLeft)
            print("Left");
        if (swipeControls.SwipeRight)
            print("Right");
        if (swipeControls.SwipeUp)
            print("up");
        if (swipeControls.SwipeDown)
            print("down");

       // player.transform.position = Vector3.MoveTowards(player.transform.position, desiredPosition, 3f * Time.deltaTime);

        if (swipeControls.Tap)
            Debug.Log("Tap");

    }
}

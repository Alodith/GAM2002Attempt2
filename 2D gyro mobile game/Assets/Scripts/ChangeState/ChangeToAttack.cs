using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeToAttack : MonoBehaviour
{

    public GameObject SwipeBar;
    public GameObject Shield;
    public BeatScroller theBS;
    public Image DefImage;
    public Image AtkImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "StateChange")
        {
            //Set Swipes to active
            SwipeBar.SetActive(true);
            //Set shield to inactive
            Shield.SetActive(false);
            //Set the bpm to 120
            theBS.beatTempo = 4f;
            //Disable the shield Icon on the hud
            DefImage.enabled = false;
            //Enable the sword icon on the hub
            AtkImage.enabled = true;

        }
    }
}

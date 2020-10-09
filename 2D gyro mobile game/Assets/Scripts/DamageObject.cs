﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObject : MonoBehaviour
{
    public bool blocked;
    public AudioSource blocksound;
    

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
            if (blocked)
            {
                gameObject.SetActive(false);
                //This means the player has blocked the object successfully

            }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Shield")
        {
            blocked = true;
            blocksound.Play();
        }
        //else if (other.tag == "BottomCollider") deal damage to the player and trigger the damage animation.
    }

    
}

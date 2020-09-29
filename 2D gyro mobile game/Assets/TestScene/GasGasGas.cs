using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasGasGas : MonoBehaviour
{

    public AudioSource Audio;
    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();
        Audio.Pause();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Audio.Play(0);

        }
            
      
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Audio.Pause();

        }


    }
}

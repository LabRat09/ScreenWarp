using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour {
    
    Rigidbody2D rb;
    

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            rb.freezeRotation = false;
            //GetComponent<ScreenWarp>().enabled = true;
            GetComponent<PlayerMovement>().enabled = true;
            

        }
    }
}

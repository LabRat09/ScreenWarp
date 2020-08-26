using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySwap : MonoBehaviour {
    public bool swapped = false;
    public float speed = 300;

    public CharacterController2D controller;
    private AudioSource audioSource;

    public AudioClip FlipUp;

    void Start ()
    {
        audioSource = Camera.main.GetComponent<AudioSource>();
        UpdateGravityDirection();
    }
    private void Update() 
    {
         if(Input.GetButtonDown("Interact"))
        {
        //Switch which direction gravity will go
        swapped = !swapped;
        audioSource.clip = FlipUp;
        audioSource.Play();
        UpdateGravityDirection();
        }
    }
	void UpdateGravityDirection()
    {
		if(swapped == true)
        {
            Physics2D.gravity = new Vector2(0, 9.8f);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 180), speed * Time.deltaTime);

        }
        if (swapped == false)
        {
            Physics2D.gravity = new Vector2(0, -9.8f);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, 0, 0), speed * Time.deltaTime);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySwap : MonoBehaviour {
    public bool swapped = false;
    public float speed = 300;

    public CharacterController2D controller;
    private AudioSource audioSource;

    public AudioClip FlipUp;

    // Use this for initialization
    void Start ()
    {
        audioSource = Camera.main.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetButtonDown("Interact"))
        {
            swapped = !swapped;
            audioSource.clip = FlipUp;
            audioSource.Play();
        }

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

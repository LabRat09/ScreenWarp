using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSound : MonoBehaviour {
    private AudioSource audioSource;

    Vector2 speed;
    public float speedOfImpact = 24;
    public Vector3 soundOffest;

    public AudioClip fallingSound;
    public AudioClip loudImpactSound;
    public AudioClip mediumImpactSound;
    public AudioClip lightImpactSound;

    public Camera mainCam;
    // Use this for initialization
    void Start ()
    {
        mainCam = Camera.main;
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        speed = GetComponent<Rigidbody2D>().velocity;

        if (gameObject.transform.position.y > GetComponent<ScreenWarp>().teleportScaleY * mainCam.orthographicSize || gameObject.transform.position.y < -GetComponent<ScreenWarp>().teleportScaleY * mainCam.orthographicSize)
        {
            Vector3 pos = mainCam.transform.position + soundOffest;
            AudioSource.PlayClipAtPoint(fallingSound, pos);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (speed.y > speedOfImpact || speed.y < -speedOfImpact || speed.x > speedOfImpact || speed.x < -speedOfImpact)
        {
            audioSource.clip =  loudImpactSound;
            audioSource.Play();
        }
        else if (speed.y > speedOfImpact * 0.5f || speed.y < -speedOfImpact * 0.5f || speed.x > speedOfImpact * 0.5f  || speed.x < -speedOfImpact * 0.5f)
        {
            audioSource.clip = mediumImpactSound;
            audioSource.Play();
        }
        else if (speed.y > speedOfImpact * 0.25f || speed.y < -speedOfImpact * 0.25f || speed.x > speedOfImpact * 0.25f || speed.x < -speedOfImpact * 0.25f)
        {
            audioSource.clip = lightImpactSound;
            audioSource.Play();
        }
    }
}

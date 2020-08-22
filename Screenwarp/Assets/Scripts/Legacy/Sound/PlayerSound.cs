using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSound : MonoBehaviour {

    private AudioSource audioSource;

    public AudioClip stepSoundOne;
    public AudioClip stepSoundTwo;

    public AudioClip landingSound;
    public AudioClip ImpactSound;
    public AudioClip jumpSound;

    public AudioClip fallingSound;

    public Vector3 soundOffest;

    Vector2 speed;
    public float speedOfImpact = 30;

    Camera mainCam;

    void Start ()
    {
        mainCam = Camera.main;
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        
        if(gameObject.transform.position.y > GetComponent<ScreenWarp>().teleportScaleY * mainCam.orthographicSize|| gameObject.transform.position.y < -GetComponent<ScreenWarp>().teleportScaleY * mainCam.orthographicSize)
        {
            Vector3 pos = mainCam.transform.position + soundOffest;
            AudioSource.PlayClipAtPoint(fallingSound, pos);
        }
        speed = GetComponent<Rigidbody2D>().velocity;
        
        if (speed.y > speedOfImpact || speed.y < -speedOfImpact || speed.x > speedOfImpact || speed.x < -speedOfImpact)
        {
           // Debug.Log("SpeedEqualOrGreater");
        }
        if (GetComponent<PlayerMovement>().isGrounded == true)
        {
            if(Input.GetButtonDown("Jump"))
            {
                audioSource.clip = jumpSound;
                audioSource.Play();
            }
        }

    }

    void OnFirstStep ()
    {
        audioSource.clip = stepSoundOne;
        audioSource.Play();
    }

    void OnSecondStep()
    {
        audioSource.clip = stepSoundTwo;
        audioSource.Play();
    }

    void OnLanding()
    {
        if (speed.y < 0.5f)
        {
            audioSource.clip = landingSound;
            audioSource.Play();
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (GetComponent<PlayerMovement>().isGrounded == false)
        {
            if (speed.y > speedOfImpact || speed.y < -speedOfImpact || speed.x > speedOfImpact || speed.x < -speedOfImpact)
            {
                audioSource.clip = ImpactSound;
                audioSource.Play();
            }
          
        }
    }


}

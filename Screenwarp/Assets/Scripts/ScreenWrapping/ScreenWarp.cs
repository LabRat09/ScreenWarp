using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWarp : MonoBehaviour {
    //ScreenWarp
     float teleportPosX = 100f;
     float teleportPosY = 100f;

     public float teleportScaleX = 1.76f;
     public float teleportScaleY = 1.0f;
    //Screen intersection clone
    public GameObject cloneReflectionL;
    public GameObject cloneReflectionR;
    Vector3 offset;
    Vector3 offset2;

    Camera mainCam;

    // Use this for initialization
    private void Awake()
    {
        if (cloneReflectionL != null)
        {
            Transform detachparentransform =
                cloneReflectionR.transform;
            detachparentransform.parent = null;
        }
        if (cloneReflectionR != null)
        {
            Transform detachparentransform =
               cloneReflectionL.transform;
            detachparentransform.parent = null;

        }
    }
    void Start ()
    {
        mainCam = Camera.main;
        Vector3 pos = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Vector3 camPos = Camera.main.transform.position;

        teleportPosX = teleportScaleX * mainCam.orthographicSize;
        teleportPosY = teleportScaleY * mainCam.orthographicSize;
        //X axis
        if (transform.position.x > teleportPosX)
        {
            Vector3 pos = transform.position;
            pos.x = -teleportPosX;
            transform.position = pos;
        }
        if (transform.position.x < -teleportPosX)
        {
            Vector3 pos = transform.position;
            pos.x = teleportPosX;
            transform.position = pos;
        }
        //y axis
        if (transform.position.y > teleportPosY)
        {
            Vector3 pos = transform.position;
            pos.y = -teleportPosY;
            transform.position = pos;
        }
        if (transform.position.y < -teleportPosY)
        {
            Vector3 pos = transform.position;
            pos.y = teleportPosY;
            transform.position = pos;
        }

        //Clone when passing through the screen portal to show body halfway sticking through the other side
        offset.x = teleportPosX * 2;
        offset2.x = -teleportPosX * 2;
        Vector3 selfPos = transform.position;
        
        if (cloneReflectionL != null)
        {
            cloneReflectionL.transform.position = selfPos + offset2;
            cloneReflectionL.transform.localScale = transform.localScale;
            cloneReflectionL.transform.rotation = transform.rotation;
        }
        if(cloneReflectionR != null)
        {
            cloneReflectionR.transform.position = selfPos + offset;
            cloneReflectionR.transform.localScale = transform.localScale;
            cloneReflectionR.transform.rotation = transform.rotation;
        }


    }
}

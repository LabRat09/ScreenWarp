using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public GameObject Target = null;

    public bool Activated = true;


    public Vector3 Offest;
    public Component warpComponent; 
	void Update ()
    {

        

        Vector3 targetPos = Target.transform.position;
        if (Activated == true)
        {
            transform.position = targetPos + Offest;
        }

    }
}

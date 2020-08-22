using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCameraAnimation : MonoBehaviour {
    public Animator animator;
    public int menuScreenNumber = 0;
    public int maxNumber = 1;
    public int minNumber = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(menuScreenNumber > maxNumber)
        {
            menuScreenNumber = maxNumber;
        }
        if (menuScreenNumber < minNumber)
        {
            menuScreenNumber = minNumber;
        }


       if (Input.GetButtonDown("Select"))
        {
            if(menuScreenNumber != maxNumber)
            {
                menuScreenNumber++;
            }
        }

        if (Input.GetButtonDown("Return"))
        {
            if (menuScreenNumber != minNumber)
            {
                menuScreenNumber--;
            }
        }
        animator.SetInteger("CameraInt", menuScreenNumber);
        //Debug.Log(menuScreenNumber);
        
    }
}

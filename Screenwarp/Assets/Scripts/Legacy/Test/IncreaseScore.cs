using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseScore : MonoBehaviour {

    public GameObject target;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(Input.GetButtonDown("Jump"))
        {
            target.GetComponent<Score>().testingNumber++;
        }
        if (Input.GetButtonDown("Crouch"))
        {
            target.GetComponent<Score>().testingNumber--;
        }
    }
}

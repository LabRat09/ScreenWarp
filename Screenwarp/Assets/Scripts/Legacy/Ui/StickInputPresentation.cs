using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickInputPresentation : MonoBehaviour {
    Vector3 pos;
    public float speed = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //pos = transform.position;
        //pos.x = Input.GetAxisRaw("Horizontal") * speed;
        //pos.y = Input.GetAxisRaw("Vertical") * speed;
        transform.localPosition =  new Vector3(Input.GetAxisRaw("Horizontal") * speed, Input.GetAxisRaw("Vertical") * speed, 0);

    }
}

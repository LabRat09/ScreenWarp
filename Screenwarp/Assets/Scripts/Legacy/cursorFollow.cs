using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorFollow : MonoBehaviour {
    public Animator animator;
   
    float speed = 99999999;
    Vector3 pos;

    Vector3 curPos;
    Vector3 lastPos;
	// Use this for initialization
	void Start () {
        
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {

        curPos = transform.position;
        if (curPos == lastPos)
        {
            
            animator.SetBool("Idle", true);
        }
        else
        {
            
            animator.SetBool("Idle", false);
        }
        lastPos = curPos;


        Cursor.visible = false;
        pos = Input.mousePosition;
        pos = Camera.main.ScreenToWorldPoint(pos);
        pos.z = 0;
        transform.position = Vector3.Lerp(transform.position, pos, speed * Time.deltaTime);
    }
}

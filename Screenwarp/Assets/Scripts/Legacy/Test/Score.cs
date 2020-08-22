using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
    public GameObject textTarget;
    public int testingNumber = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(testingNumber);
        
        textTarget.GetComponent<TextMesh>().text = (""+testingNumber);
    }
}

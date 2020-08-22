using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenDummy : MonoBehaviour {

    public GameObject dummyPrefabL;
    Vector3 offset;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        offset.x = 3;
        //Vector3 targetPos = dummyPrefab.transform.position;
        //targetPos = transform.position;
        Vector3 selfPos = transform.position;
        
        if (dummyPrefabL != null)
        {
            dummyPrefabL.transform.position = selfPos + offset;
            
        }

        
    }
}

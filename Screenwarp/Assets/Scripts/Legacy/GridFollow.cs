﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridFollow : MonoBehaviour {

  

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {



        Vector3 targetPos = Camera.main.transform.position;
        Vector3 pos = transform.position;
        //pos.x = 3;
        //Debug.Log(targetPos);
    }
}

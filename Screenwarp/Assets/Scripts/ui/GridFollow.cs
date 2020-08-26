using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridFollow : MonoBehaviour {

    //makes the grid in the menu follow the camera for the "falling" looking effect for the menu screen
    void Update()
    {
        Vector3 targetPos = Camera.main.transform.position;
        Vector3 pos = transform.position;
    }
}

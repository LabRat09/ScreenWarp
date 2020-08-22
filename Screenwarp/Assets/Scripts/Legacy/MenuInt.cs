using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInt : MonoBehaviour
{
    public int menuInt = 0;
    public int minInt = 0;
    public int maxInt = 3;

    float yInput = 0f;

    void Update()
    {
        yInput = Input.GetAxisRaw("Vertical");
        Debug.Log(yInput);
    }
}

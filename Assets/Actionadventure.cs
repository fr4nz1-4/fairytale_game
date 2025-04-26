using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Actionadventure : MonoBehaviour
{
    public Vector3 mousePosition;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("left mouse click");
            mousePosition = Input.mousePosition;
            print(mousePosition);
        }
    }
}

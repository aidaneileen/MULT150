using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIY_PlayerScript : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        // Reading in Specific Key Presses
        if (Input.GetKey(KeyCode.M))
            print("The 'M' key is pressed down");

        if (Input.GetKey(KeyCode.O))
            print("The 'O' key is pressed down");
        
        // Reading Mouse and Keyboard Axis Input
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");
        float hVal = Input.GetAxis("Horizontal");
        float vVal = Input.GetAxis("Vertical");

        if (mxVal != 0)
            print("Mouse X movement selected: " + mxVal);

        if (myVal != 0)
            print("Mouse Y movement selected: " + myVal);

        if (hVal != 0)
            print("Horizontal movement selected: " + hVal);

        if (vVal != 0)
            print("Vertical movement selected: " + vVal);
    }
}
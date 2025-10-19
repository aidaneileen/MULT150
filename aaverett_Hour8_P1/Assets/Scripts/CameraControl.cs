using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
   public float moveSpeed = 5f;
    public bool invertY = false; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");
        if (invertY)
            my = -my;

        Vector3 delta =
        (transform.right * mx + transform.up * my) * moveSpeed * Time.deltaTime;
        transform.position += delta;
    }
}

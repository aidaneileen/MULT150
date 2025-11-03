using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    public float speed = 5.0f;

    void Start()
    {
        
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        
        Vector3 move = new Vector3(moveX, moveY, 0f) * speed * Time.deltaTime;
        transform.Translate(move, Space.World);

        Vector3 p = transform.position;
        p.z = -5f;              
        transform.position = p;
    }
}

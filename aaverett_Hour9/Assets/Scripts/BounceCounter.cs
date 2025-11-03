using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    private int count = 0;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Sphere")
        {
            count++;
            print("Bounce count: " + count);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

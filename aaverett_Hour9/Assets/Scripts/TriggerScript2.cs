using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript2 : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Sphere")
            print("ENTER: " + gameObject.name + " with " + other.name);
    }

    void OnTriggerStay(Collider other)
    {
        if (other.name == "Sphere")
            print("INSIDE: " + gameObject.name + " with " + other.name);
    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == "Sphere")
            print("EXIT: " + gameObject.name + " with " + other.name);
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

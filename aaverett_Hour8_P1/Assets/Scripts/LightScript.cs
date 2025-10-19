using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    Light lightComponent;
    void Start()
    {
        lightComponent = GetComponent<Light>();
        lightComponent.type = LightType.Point;
        lightComponent.enabled = true;
        Debug.Log("Press L to turn light on or off.");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            lightComponent.enabled = !lightComponent.enabled;
            Debug.Log("Light enabled: " + lightComponent.enabled);
        }
    }
}

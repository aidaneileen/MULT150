using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{

    public GameObject prefab;
    
    void Start()
    {
        float x = 3f;
        float y = 2f;
        float z = -5f;
        
        for (int i = 0; i < 10; i++)
        {
            Instantiate(prefab, new Vector3(x, y, z), Quaternion.identity);
            x = x + 2f;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
                Instantiate(prefab);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
                Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}

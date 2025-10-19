using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TIY_FireBallScript : MonoBehaviour
{
    // Method 1
    int TakeDamageFromFireball()
    {
        int health = 100;
        int damage = 10;
        return health - damage;
    }
    // Method 2
        int TakeDamageFromFireball(int damage)
    {
        int health = 100;
        return health - damage;
    }
    // Method 3
    int TakeDamageFromFireball(int damage, int multipler)
    {
        int health = 100;
        return health - (damage * multipler);
    }

    // Start is called before the first frame update
    void Start()
    {
       int x = TakeDamageFromFireball();
       print("Player health: " + x);

       int y = TakeDamageFromFireball(25);
       print("Player health: " + y);

       int z = TakeDamageFromFireball(30, 50);
       print("Player health: " + z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

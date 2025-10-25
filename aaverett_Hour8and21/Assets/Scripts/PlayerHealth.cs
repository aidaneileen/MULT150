using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Declare variable for healthpoints
    int healthpoints = 3992;

    void Start()
    {
        // Adds 400 health -> run it four times
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);
        healthpoints = UsePotion(healthpoints);

        // Prints final health value
        Debug.Log("Final healthpoints: " + healthpoints);
    }

    void Update()
    {

    }

    // Adds 400 to health
    int UsePotion(int health)
    {
        health = health + 400;
        return health;
    }
}

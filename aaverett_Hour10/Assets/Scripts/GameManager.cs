using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GoalScript blue, green, red, orange;
    public GoalScript chaos;
    private bool isGameOver = true;
    private float timer = 0f;

    void Update()
    {
        // If all four goals are solved, then the game is over
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved;

        if (!isGameOver)
        {
            timer += Time.deltaTime;
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10,10,200,30), "Time: " + timer.ToString("F2") + "s");

        if (isGameOver)
        {
            Rect rect = new Rect (Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
            GUI.Box (rect, "Game Over");
             
            Rect rect2 = new Rect (Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
            GUI.Label (rect2, "Great Job!");
             
            Rect rect3 = new Rect(Screen.width / 2 - 40, Screen.height / 2, 200, 50);
            GUI.Label(rect3, "Final Time: " + timer.ToString("F2") + "s");
        }
    }
}

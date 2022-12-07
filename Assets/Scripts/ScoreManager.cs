using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int score = 0;

    void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    public void AddScore()
    {
        score = score + 1;
        Debug.Log("Your score is: " + score);
    }
}

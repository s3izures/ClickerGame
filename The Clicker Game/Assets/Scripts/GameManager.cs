using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance{ get; private set; }
    private int annoyancePoints = 0;

    void Start()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void modifyPoints(int amount)
    {
        annoyancePoints += amount;
    }
    public int getPoints()
    {
        return annoyancePoints;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickGenerator : MonoBehaviour
{
    [SerializeField] int addAmount = 0;
    [SerializeField] float time = 0;

    void Start()
    {
        InvokeRepeating("AddPoints", 1, time);
    }

    void AddPoints()
    {
        GameManager.Instance.ModifyPoints(addAmount);
    }

}

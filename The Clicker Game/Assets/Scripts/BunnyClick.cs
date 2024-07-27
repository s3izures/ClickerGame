using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyClick : MonoBehaviour
{
    [SerializeField] private int addPoints = 1;

    public void ClickBunny()
    {
        GameManager.Instance.ModifyPoints(addPoints);
    }
}

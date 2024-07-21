using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pointsDisplay;

    void Update()
    {
        pointsDisplay.text = GameManager.Instance.getPoints().ToString();
    }
}

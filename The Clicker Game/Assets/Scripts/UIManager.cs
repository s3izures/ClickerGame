using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pointsDisplay;
    [SerializeField] CanvasGroup gro;
    [SerializeField] GameObject shop;
    [SerializeField] Animator anim;

    void Update()
    {
        pointsDisplay.text = GameManager.Instance.getPoints().ToString();
    }

    public void OpenShop()
    {
        shop.SetActive(true);

        gro.alpha = 1.0f;
        gro.interactable = true;
        anim.Play("Shop Open");
    }
    public void CloseShop()
    {
        gro.interactable = false;
        anim.Play("Shop Close");
    }
}

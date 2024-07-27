using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pointsDisplay;
    [SerializeField] CanvasGroup gro;
    [SerializeField] GameObject shop;
    [SerializeField] Animator animShop;

    [SerializeField] List<BuyItem> items;

    void Update()
    {
        pointsDisplay.text = GameManager.Instance.GetPoints().ToString();
    }

    public void OpenShop()
    {
        shop.SetActive(true);

        gro.alpha = 1.0f;
        gro.interactable = true;
        animShop.Play("Shop Open");
    }
    public void CloseShop()
    {
        gro.interactable = false;
        animShop.Play("Shop Close");
    }
    private void ActivateButton()
    {
        foreach (BuyItem i in items)
        {
            if(i.itemCost >= GameManager.Instance.GetPoints())
            {
                i.ToggleItem(false);
            }
            else
            {
                i.ToggleItem(true);
            }
        }
    }
}

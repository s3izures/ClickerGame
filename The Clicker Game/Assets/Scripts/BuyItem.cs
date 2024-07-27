using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyItem : MonoBehaviour
{
    [SerializeField] public int itemCost = 0;
    [SerializeField] GameObject itemPrefab;
    [SerializeField] Transform where;

    public void buyItem()
    {
        if(GameManager.Instance.GetPoints() >=  itemCost)
        {
            GameManager.Instance.ModifyPoints(-itemCost);
            Instantiate(itemPrefab, where);
        }
    }
    public void ToggleItem(bool onOff)
    {
        gameObject.SetActive(onOff);
    }

}

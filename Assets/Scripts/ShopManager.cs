using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public ShopItemSO[] shopItems;

    void Start()
    {
        foreach (var itemSO in shopItems)
        {
            ShopItem item = itemSO.shopItemData;
            Debug.Log($"Item Name: {item.itemName}, Price: {item.price}, Description: {item.description}");
        }
    }
}

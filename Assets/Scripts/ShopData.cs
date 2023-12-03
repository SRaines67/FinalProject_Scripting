using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]

public class ShopItem
{
    //item data
    public string itemName;
    public int price;
    public string description;

    public ShopItem(string itemName, int price, string description)
    {
        this.itemName = itemName;
        this.price = price;
        this.description = description;
    }
}


using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Shop Inventory", menuName = "Shop/ShopInventory")]
public class ShopInventory : ScriptableObject
{
    [SerializeField]
    private List<ShopItem> shopItems = new List<ShopItem>();

    public List<ShopItem> ShopItems => shopItems;

    public void AddShopItem(ShopItem shopItem)
    {
        shopItems.Add(shopItem);
    }
}

using UnityEngine;

public enum ShopItemCategory
{
    Weapon,
    Armor,
    Consumable
}
[System.Serializable]
public class ShopItem
{
    [Header("General Information")]
    [SerializeField] private string itemName;
    [SerializeField] private int price;
    [SerializeField] private string description;
    [SerializeField] private int itemQuantity;
    [SerializeField] private ShopItemCategory category;

    public string ItemName => itemName;
    public int Price => price;
    public string Description => description;
    public int ItemQuantity => itemQuantity;
    public ShopItemCategory Category => category;
}
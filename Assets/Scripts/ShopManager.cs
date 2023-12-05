using UnityEngine;

public class ShopManager : MonoBehaviour
{
    [SerializeField]
    private ShopInventory shopInventory;

    public void AddShopItem(ShopItem shopItem)
    {
        if (shopInventory != null)
        {
            shopInventory.AddShopItem(shopItem);
            Debug.Log("Shop item added to the inventory.");
        }
        else
        {
            Debug.LogWarning("ShopInventory not assigned in the ShopManager.");
        }
    }
}

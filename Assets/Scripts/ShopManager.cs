using UnityEngine;

public class ShopManager : MonoBehaviour
{
    [SerializeField]
    private string newShopInventoryName = "NewShopInventory";

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

#if UNITY_EDITOR
    public void GenerateShopInventory()
    {
        // Create a new ShopInventory Scriptable Object
        ShopInventory newShopInventory = ScriptableObject.CreateInstance<ShopInventory>();

        // Set the name for the new ShopInventory
        newShopInventory.name = newShopInventoryName;

        // Save the ShopInventory asset to the Assets folder
        string path = $"Assets/Scripts/ShopList/{newShopInventoryName}.asset";
        UnityEditor.AssetDatabase.CreateAsset(newShopInventory, path);
        UnityEditor.AssetDatabase.SaveAssets();
        UnityEditor.AssetDatabase.Refresh();

        Debug.Log($"ShopInventory '{newShopInventoryName}' generated and saved at path: {path}");
    }
#endif
}

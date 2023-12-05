#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ShopInventory))]
public class ShopInventoryEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        ShopInventory shopInventory = (ShopInventory)target;

        if (GUILayout.Button("Print Item Details to Console"))
        {
            PrintItemDetails(shopInventory);
        }
    }

    private void PrintItemDetails(ShopInventory shopInventory)
    {
        foreach (var shopItem in shopInventory.ShopItems)
        {
            Debug.Log($"Item Name: {shopItem.ItemName}, Price: {shopItem.Price}, Description: {shopItem.Description}, Category: {shopItem.Category}");
        }
    }
}
#endif

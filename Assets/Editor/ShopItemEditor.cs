#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ShopItem))]
public class ShopItemEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        ShopItem shopItem = ((MonoBehaviour)target).GetComponent<ShopItem>();

        if (GUILayout.Button("Add to Shop Inventory"))
        {
            ShopInventory shopInventory = AssetDatabase.LoadAssetAtPath<ShopInventory>("Assets/Scripts/ShopInventory.asset");

            if (shopInventory != null)
            {
                shopInventory.AddShopItem(shopItem);
                Debug.Log("Shop item added to the inventory.");
            }
            else
            {
                Debug.LogWarning("ShopInventory asset not found. Make sure it is located at the correct path.");
            }
        }
    }
}
#endif

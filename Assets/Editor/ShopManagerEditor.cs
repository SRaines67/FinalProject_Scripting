#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ShopManager))]
public class ShopManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        ShopManager shopManager = (ShopManager)target;

        if (GUILayout.Button("Generate Shop Inventory"))
        {
            shopManager.GenerateShopInventory();
        }
    }
}
#endif

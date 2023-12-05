using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public GameObject shopUI; // Assign your Shop UI GameObject in the Unity Editor

    public void Interact()
    {
        // Open the shop UI
        if (shopUI != null)
        {
            shopUI.SetActive(true);
            // You can add additional logic here, such as disabling player controls while the shop is open
        }
    }
}

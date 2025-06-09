using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private GameObject inventoryPanel;
    [SerializeField] private Button backButton;

    private void Start()
    {
        backButton.onClick.AddListener(() => UIManager.Instance.OpenMainMenu());
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;

    private void OpenStatus() => UIManager.Instance.OpenStatus();
    private void OpenInventory() => UIManager.Instance.OpenInventory();

    private void Start()
    {
        statusButton.onClick.AddListener(OpenStatus);
        inventoryButton.onClick.AddListener(OpenInventory);
    }

    public void SetMainButtonsActive(bool isActive)
    {
        statusButton.gameObject.SetActive(isActive);
        inventoryButton.gameObject.SetActive(isActive);
    }
}

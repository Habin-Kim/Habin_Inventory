using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private UIMainMenu uiMainMenu;
    [SerializeField] private UIStatus uiStatus;
    [SerializeField] private UIInventory uiInventory;

    public UIMainMenu MainMenu => uiMainMenu;
    public UIStatus StatusUI => uiStatus;
    public UIInventory InventoryUI => uiInventory;

    public static UIManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null) Instance = this;

        else
        {
            Destroy(gameObject);
            return;
        }
    }

    public void OpenMainMenu()
    {
        StatusUI.gameObject.SetActive(false);
        InventoryUI.gameObject.SetActive(false);
        uiMainMenu.SetMainButtonsActive(true);
    }

    public void OpenStatus()
    {
        uiStatus.gameObject.SetActive(true);
        uiMainMenu.SetMainButtonsActive(false);
    }

    public void OpenInventory()
    {
        uiInventory.gameObject.SetActive(true);
        uiMainMenu.SetMainButtonsActive(false);
    }
}

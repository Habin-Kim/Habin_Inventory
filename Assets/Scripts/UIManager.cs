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

    /// <summary>
    /// 스테이터스, 인벤토리 비활성화 메인메뉴 버튼 활성화
    /// </summary>
    public void OpenMainMenu()
    {
        StatusUI.gameObject.SetActive(false);
        InventoryUI.gameObject.SetActive(false);
        uiMainMenu.SetMainButtonsActive(true);
    }

    /// <summary>
    /// 스테이터스 활성화
    /// </summary>
    public void OpenStatus()
    {
        uiStatus.gameObject.SetActive(true);
        uiMainMenu.SetMainButtonsActive(false);
    }

    /// <summary>
    /// 인벤토리 활성화
    /// </summary>
    public void OpenInventory()
    {
        uiInventory.gameObject.SetActive(true);
        uiMainMenu.SetMainButtonsActive(false);
    }
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Button backButton;
    [SerializeField] private TextMeshProUGUI itemAmountText;

    [Header("슬롯 세팅")]
    [SerializeField] private GameObject slotPrefab;
    [SerializeField] private Transform slotParent; // 스크롤 뷰 컨텐트
    [SerializeField] private int maxSlotCount = 18; //슬롯 최대 생성 수

    private List<UISlot> slots = new List<UISlot>();

    private void Start()
    {
        backButton.onClick.AddListener(() => UIManager.Instance.OpenMainMenu());
        InitInventoryUI();
        SetContentSize();
    }

    public void InitInventoryUI()
    {
        List<ItemData> inventory = GameManager.Instance.player.Inventory;

        for (int i = 0; i < maxSlotCount; i++)
        {
            GameObject slotGO = Instantiate(slotPrefab, slotParent);
            UISlot slot = slotGO.GetComponent<UISlot>();
            slots.Add(slot);

            if (i < inventory.Count)
            {
                slot.SetItem(inventory[i]);
            }
            else
            {
                slot.SetItem(null);
            }
        }

        UpdateItemAmountUI();
    }

    /// <summary>
    /// 스크롤 뷰 컨텐트 Y 크기
    /// </summary>
    private void SetContentSize()
    {
        GridLayoutGroup grid = slotParent.GetComponent<GridLayoutGroup>();
        int rows = Mathf.CeilToInt(maxSlotCount / grid.constraintCount);

        float contentHeight = grid.padding.top + rows * (grid.cellSize.y + grid.spacing.y);
        RectTransform rt = slotParent.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(rt.sizeDelta.x, contentHeight);
    }

    /// <summary>
    /// 인벤토리 아이템 / 최대 텍스트
    /// </summary>
    private void UpdateItemAmountUI()
    {
        int count = GameManager.Instance.player.Inventory.Count;
        itemAmountText.text = $"{count} / {maxSlotCount}";
    }
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private GameObject inventoryPanel;
    [SerializeField] private Button backButton;

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

    private void InitInventoryUI()
    {
        for (int i = 0; i < maxSlotCount; i++)
        {
            GameObject slotGO = Instantiate(slotPrefab, slotParent);
            UISlot slot = slotGO.GetComponent<UISlot>();
            slots.Add(slot);
        }
    }

    private void SetContentSize()
    {
        GridLayoutGroup grid = slotParent.GetComponent<GridLayoutGroup>();
        int rows = Mathf.CeilToInt(maxSlotCount / grid.constraintCount);

        float contentHeight = grid.padding.top + rows * (grid.cellSize.y + grid.spacing.y);
        RectTransform rt = slotParent.GetComponent<RectTransform>();
        rt.sizeDelta = new Vector2(rt.sizeDelta.x, contentHeight);
    }
}

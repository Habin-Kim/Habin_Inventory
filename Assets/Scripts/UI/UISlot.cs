using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image iconImage;

    private ItemData itemData;

    /// <summary>
    /// 슬롯에 표시할 데이터 설정
    /// </summary>
    public void SetItem(ItemData data)
    {
        itemData = data;
        RefreshUI();
    }

    /// <summary>
    /// 현재 itemData 값에 따라 UI 갱신
    /// </summary>
    public void RefreshUI()
    {
        if (itemData != null)
        {
            iconImage.sprite = itemData.Icon;
            iconImage.enabled = true;
        }
        else
        {
            iconImage.sprite = null;
            iconImage.enabled = false;
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image iconImage;
    [SerializeField] private Button slotButton;
    [SerializeField] private GameObject equipSign;

    private bool isEquipped = false;
    private ItemData itemData;

    private void Start()
    {
        slotButton.onClick.AddListener(OnClickSlot);
        equipSign.SetActive(false);
    }

    private void OnClickSlot()
    {
        if (itemData != null)
        {
            Character player = GameManager.Instance.player;

            // 이미 장착된 경우 해제
            if (isEquipped)
            {
                Debug.Log("해제작동");
                player.UnEquip(itemData);
                equipSign.SetActive(false);
                isEquipped = false;
            }
            else
            {
                Debug.Log("장착작동");
                player.Equip(itemData);
                equipSign.SetActive(true);
                isEquipped = true;
            }

            // 상태창 갱신
            UIManager.Instance.StatusUI.SetCharacterInfo(player);
        }
    }

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

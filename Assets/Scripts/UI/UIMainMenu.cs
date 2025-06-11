using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI goldText;

    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;

    private void OpenStatus() => UIManager.Instance.OpenStatus();
    private void OpenInventory() => UIManager.Instance.OpenInventory();

    private void Start()
    {
        statusButton.onClick.AddListener(OpenStatus);
        inventoryButton.onClick.AddListener(OpenInventory);
    }

    /// <summary>
    /// 메인의 스테이터스, 인벤토리의 활성화 상태를 담당
    /// </summary>
    /// <param name="isActive"></param>
    public void SetMainButtonsActive(bool isActive)
    {
        statusButton.gameObject.SetActive(isActive);
        inventoryButton.gameObject.SetActive(isActive);
    }

    /// <summary>
    /// 캐릭터의 이름과 레벨을 담당
    /// </summary>
    /// <param name="character"></param>
    public void SetCharacterInfo(Character character)
    {
        nameText.text = character.Name;
        levelText.text = $"LV {character.Level}";
    }
}

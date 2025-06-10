using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIStatus : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI atkText;
    [SerializeField] private TextMeshProUGUI defText;
    [SerializeField] private TextMeshProUGUI hpText;
    [SerializeField] private TextMeshProUGUI criText;

    [SerializeField] private Button backButton;

    private void Start()
    {
        backButton.onClick.AddListener(() => UIManager.Instance.OpenMainMenu());
    }

    /// <summary>
    /// 캐릭터의 스테이터스를 담당
    /// </summary>
    /// <param name="character"></param>
    public void SetCharacterInfo(Character character)
    {
        hpText.text = $"{character.HP}";
        atkText.text = $"{character.ATK}";
        defText.text = $"{character.DEF}";
        criText.text = $"{character.CRI}";
    }
}

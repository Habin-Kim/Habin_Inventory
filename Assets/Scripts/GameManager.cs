using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Character player { get; private set; }

    void Start()
    {
        SetData();
    }

    /// <summary>
    /// 플레이어 초기 데이터 설정
    /// </summary>
    private void SetData()
    {
        player = new Character("Chad", 1, 35, 40, 100, 10);

        UIManager.Instance.MainMenu.SetCharacterInfo(player);
        UIManager.Instance.StatusUI.SetCharacterInfo(player);

        UIManager.Instance.MainMenu.SetMainButtonsActive(true);

        UIManager.Instance.StatusUI.gameObject.SetActive(false);
    }
}

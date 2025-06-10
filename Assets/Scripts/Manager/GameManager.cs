using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Character player { get; private set; }

    [SerializeField] private List<Item> itemObjects;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        SetData();
        UIManager.Instance.InventoryUI.InitInventoryUI();
    }

    /// <summary>
    /// 플레이어 초기 데이터 설정
    /// </summary>
    private void SetData()
    {
        player = new Character("Chad", 1, 35, 40, 100, 10);

        foreach (var itemObj in itemObjects)
        {
            if (itemObj != null && itemObj.Data != null)
            {
                player.AddItem(itemObj.Data);
            }
        }

        UIManager.Instance.MainMenu.SetCharacterInfo(player);
        UIManager.Instance.StatusUI.SetCharacterInfo(player);

        UIManager.Instance.MainMenu.SetMainButtonsActive(true);
        UIManager.Instance.StatusUI.gameObject.SetActive(false);
    }
}

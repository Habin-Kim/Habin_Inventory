using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class ItemData : ScriptableObject
{
    [Header("기본 정보")]
    [SerializeField] private string itemName;
    [SerializeField] private Sprite icon;
    [SerializeField] private string description;

    [Header("능력치 보너스")]
    [SerializeField] private int itemAtk;
    [SerializeField] private int itemDef;
    [SerializeField] private int itemHP;
    [SerializeField] private int itemCri;

    // 외부 접근용 Getter 프로퍼티
    public string ItemName   => itemName;
    public Sprite Icon       => icon;
    public string Description=> description;

    public int ItemAtk       => itemAtk;
    public int ItemDef       => itemDef;
    public int ItemHP        => itemHP;
    public int ItemCri       => itemCri;
}

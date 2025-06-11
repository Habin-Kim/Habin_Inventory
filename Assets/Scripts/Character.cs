using System.Collections.Generic;

public class Character
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public int HP { get; private set; }
    public int ATK { get; private set; }
    public int DEF { get; private set; }
    public int CRI { get; private set; }

    public List<ItemData> Inventory { get; private set; }
    private List<ItemData> equippedItems;

    /// <summary>
    /// 캐릭터 정보, 인벤토리 초기화
    /// </summary>
    /// <param name="name">캐릭터 이름</param>
    /// <param name="level">캐릭터 레벨</param>
    /// <param name="atk">캐릭터 공격력</param>
    /// <param name="def">캐릭터 방어력</param>
    /// <param name="hp">캐릭터 체력</param>
    /// <param name="cri">캐릭터 치명타</param>
    public Character(string name, int level, int atk, int def, int hp, int cri)
    {
        Name = name;
        Level = level;
        ATK = atk;
        DEF = def;
        HP = hp;
        CRI = cri;

        // 인벤토리 초기화
        Inventory = new List<ItemData>();
        equippedItems = new List<ItemData>();
    }

    /// <summary>
    /// 인벤토리에 아이템 추가
    /// </summary>
    public void AddItem(ItemData item)
    {
        if (item != null)
        {
            Inventory.Add(item);
        }
    }

    /// <summary>
    /// 아이템 장착: 능력치 보너스 적용
    /// </summary>
    public void Equip(ItemData item)
    {
        if (item != null && Inventory.Contains(item) && !equippedItems.Contains(item))
        {
            ATK += item.ItemAtk;
            DEF += item.ItemDef;
            HP += item.ItemHP;
            CRI += item.ItemCri;

            // equippedItems.Add(item);
        }
    }

    /// <summary>
    /// 아이템 해제: 능력치 보너스 제거
    /// </summary>
    public void UnEquip(ItemData item)
    {
        if (item != null && Inventory.Contains(item) && !equippedItems.Contains(item))
        {
            ATK -= item.ItemAtk;
            DEF -= item.ItemDef;
            HP -= item.ItemHP;
            CRI -= item.ItemCri;

            // equippedItems.Remove(item);
        }
    }
}

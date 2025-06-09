public class Character
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public int HP { get; private set; }
    public int ATK { get; private set; }
    public int DEF { get; private set; }
    public int CRI { get; private set; }

    /// <summary>
    /// 캐릭터 정보
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
    }
}

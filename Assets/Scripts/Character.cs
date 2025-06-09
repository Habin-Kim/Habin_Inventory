using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string Name { get; private set; }
    public int Level { get; private set; }
    public int HP { get; private set; }
    public int ATK { get; private set; }
    public int DEF { get; private set; }
    public int CRI { get; private set; }

    public Character(string name, int level, int hp, int atk, int def, int cri)
    {
        Name = name;
        Level = level;
        HP = hp;
        ATK = atk;
        DEF = def;
        CRI = cri;
    }
}

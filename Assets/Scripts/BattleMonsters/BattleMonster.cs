using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleMonster
{
    BattleMonsterBase monsterBase;
    int level;

    public BattleMonster(BattleMonsterBase mBase, int mLevel)
    {
        monsterBase = mBase;
        level = mLevel;
    }

    public int Hp {
        get { return Mathf.FloorToInt((monsterBase.Hp * level / 100f) + 10); }
    }

    public int Attack {
        get { return Mathf.FloorToInt((monsterBase.Attack * level / 100f) + 5); }
    }

    public int Defense {
        get { return Mathf.FloorToInt((monsterBase.Defense * level / 100f) + 5); }
    }

    public int SpAttack {
        get { return Mathf.FloorToInt((monsterBase.SpAttack * level / 100f) + 5); }
    }

    public int SpDefense {
        get { return Mathf.FloorToInt((monsterBase.SpDefense * level / 100f) + 5); }
    }

    public int Speed {
        get { return Mathf.FloorToInt((monsterBase.Speed * level / 100f) + 5); }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemyData
{
    // 敵の種類
    public enum EnemyType
    {
        Common = 0,     // ザコ敵
        Boss,           // ボス
    }

    public int ID;                     // 敵のID
    public string charaName;           // 敵の名称
    public EnemyType enemyType;        // 敵の種類
    public int hp = 0;                 // HP
}

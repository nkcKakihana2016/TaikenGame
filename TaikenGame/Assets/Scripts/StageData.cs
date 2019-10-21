using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StageData
{
    // 敵のパターンリスト
    public enum SpawnEnemys
    {
        EnemyA = 0,
        EnemyB = 1,
        EnemyC = 2,
        Boss = 3
    }
    [Header("ステージIDの設定")]
    public int stageNo;                     // ステージID
    [Header("エリア収縮のサイズの設定")]
    public float[] pulseSize;               // エリア収縮サイズの倍率
    [Header("エリア収縮開始までの猶予の設定（秒）")]
    public float[] puluseWaitTime;          // エリア収縮開始までの猶予時間
    [Header("エリア収縮までに掛かる時間の設定（秒）")]
    public float[] shrinkTime;              // エリア収縮完了までに掛かる時間

    [Header("出現させる敵パターン")]
    public SpawnEnemys[] waveTable;         // 出現する敵パターン
    [Header("出現させる敵オブジェクト")]
    public EnemyUnitManager[] waveEnemyObj; // 出現する敵のオブジェクト

}

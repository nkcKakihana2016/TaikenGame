using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class EnemyManager : MonoBehaviour
{
    // 敵のID
    [SerializeField] private int enemyID;
    // 敵データのリスト
    [SerializeField] EnemyDataList enemyDataList;
    // 敵データが格納されているクラス
    public EnemyData enemyData;
    // ダメージカウント
    [SerializeField] private IntReactiveProperty hitCount = new IntReactiveProperty(0);


    void Awake()
    {
        // IDより敵のデータリストを取得
        enemyDataList = Resources.Load<EnemyDataList>(string.Format("Enemy{0}", enemyID));
        // パラメータ取得
        enemyData = enemyDataList.EnemyDataLists[0];
    }

    // Start is called before the first frame update
    void Start()
    {
        // 衝突判定
        this.OnTriggerEnterAsObservable()
            .Where(c => c.gameObject.tag == "Bullet")
            .Subscribe(c => 
            {

            }).AddTo(this.gameObject);
    }
}

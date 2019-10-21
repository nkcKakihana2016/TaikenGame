using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class PlayerManager : MonoBehaviour
{
    public float playerSpeed;
    public Vector3 movePos;

    // Start is called before the first frame update
    void Start()
    {
        // 矢印キーが押されたら移動量を設定する
        this.UpdateAsObservable()
            .Subscribe(_ => 
            {
                // 右矢印キーが押されたら右に移動
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    movePos.x = 1.0f;
                }
                // 左矢印キーが押されたら左に移動
                else if (Input.GetKey(KeyCode.LeftArrow))
                {
                    movePos.x = -1.0f;
                }
                // 上矢印キーが押されたら上に移動
                else if (Input.GetKey(KeyCode.UpArrow))
                {
                    movePos.y = 1.0f;
                }
                // 下矢印キーが押されたら下に移動
                else if (Input.GetKey(KeyCode.DownArrow))
                {
                    movePos.y = -1.0f;
                }

                // どのキーも押されていなければ移動しないようにする
                if (Input.GetKey(KeyCode.RightArrow) == false && Input.GetKey(KeyCode.LeftArrow) == false)
                {
                    movePos.x = 0.0f;
                }
                if (Input.GetKey(KeyCode.UpArrow) == false && Input.GetKey(KeyCode.DownArrow) == false)
                {
                    movePos.y = 0.0f;
                }
            }).AddTo(this.gameObject);

        // 移動処理
        this.UpdateAsObservable()
            .Subscribe(_ => 
            {
                this.transform.position += movePos * playerSpeed * Time.deltaTime;
            }).AddTo(this.gameObject);

        // プレイヤーがエリア外であればダメージを受ける
        this.OnTriggerExitAsObservable()
            .Where(c => c.gameObject.tag == "Pulse")
            .Subscribe(c => 
            {

            }).AddTo(this.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMove : MonoBehaviour
{
    //ポーズメニューを定義
    private GameObject pauseMenu;
    //経過時間を定義
    private float time;
    //ポーズメニューのプレハブを定義
    public GameObject pauseMenuPrefab;
    //流れる速さを指定
    private float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    void FixedUpdate()
    {
        //時間の取得および計算
        time = Timer.GetLimitTime() - Timer.GetTime();

        //経過時間によって流れる速さを変更
        speed = 0.1f + (time * 0.001f);

        //ポーズメニューの存在の可否でオブジェクトの流れを制御
        pauseMenu = GameObject.Find(pauseMenuPrefab.name);
        if (pauseMenu == null)
        {
            transform.Translate(speed, 0, 0); 
        } 
    }
}

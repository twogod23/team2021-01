using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtetsukiCounter : MonoBehaviour
{
    //クリックした回数をカウント
    private int clickCounter;
    //アイテムを取得した回数をカウント
    private int getCounter;
    //ポーズメニューのプレハブを定義
    public GameObject pauseMenuPrefab;
    //お手つきのペナルティの秒数を指定
    private float stopTime = 2.0f;
    //お手つきした時間を取得
    private float otetsukiTime;
    //残り時間を取得
    private float time;
    //お手つきの真偽を判定
    private bool otetsuki;
    

    //取得したアイテムの数をカウント
    public void GetItem()
    {
        getCounter += 1;
    }
    public void PushPause()
    {
        if (otetsuki == false)
        {
            getCounter += 1;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //初期化
        clickCounter = 0;
        getCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (otetsuki == true)
        {
            time = Timer.GetTime();
            if (time < otetsukiTime - stopTime)
            {
                otetsuki = false;
                Debug.Log("stop");
            }
        }
        
        //ポーズメニューの存在の可否
            GameObject pauseMenu = GameObject.Find(pauseMenuPrefab.name);
            if (pauseMenu == null)
            {
                //クリック判定
                if (Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1) || Input.GetMouseButtonUp(2))
                {
                    clickCounter += 1;
                }
            }

        //お手つき判定
        if (clickCounter > getCounter)
        {
            Debug.Log("お手つき");
            otetsuki = true;
            clickCounter = getCounter;
            otetsukiTime = Timer.GetTime();
        }
    }
}

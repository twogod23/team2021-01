using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


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
    //ペナルティの残り時間をカウント
    private float pTime;
    //残り時間を取得
    private float time;
    //お手つきの真偽を判定
    private bool otetsuki;
    //お手つきのメッセージを表示
    public GameObject otetsukiMessage;
    //お手つきのテキストの指定
    public TextMeshProUGUI otetsukiText;
    

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
        otetsukiMessage.SetActive(false);
        otetsukiText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        //お手つきのペナルティ時
        if (otetsuki == true)
        {
            time = Timer.GetTime();
            if (time >= 0)
            {
                pTime = otetsukiTime - time;
                otetsukiText.text = (stopTime - pTime).ToString("f1");

                //ペナルティ解除
                if (pTime > stopTime)
                {
                    otetsuki = false;
                    otetsukiMessage.SetActive(false);
                    otetsukiText.text = "";
                    Debug.Log("stop");
                }
            }
            //時間切れの際、強制的に解除
            else
            {
                otetsukiMessage.SetActive(false);
            }
        }
        //ペナルティが無いとき
        else
        {
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
        }
        
        //お手つき判定
        if (clickCounter > getCounter)
        {
            //クリックした回数を補正
            clickCounter = getCounter;
            //一度でもアイテムを取ったことがある際にお手つきを適用
            if (getCounter > 0)
            {
                Debug.Log("お手つき");
                otetsukiMessage.SetActive(true);
                otetsuki = true;
                otetsukiTime = Timer.GetTime();
            }
        }
    }
}

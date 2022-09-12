using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    //制限時間の指定
    public static float countdown = 120.0f;
    //テキストの指定
    public TextMeshProUGUI timer;
    //終了済みの真偽を判定
    private bool timeup = false;
    //終了後の時間を計測
    private float timeupTime = 2.0f;
    //終了後のメッセージを指定
    public GameObject prefabEndMessage;

    // Start is called before the first frame update
    void Start()
    {
        timer.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(countdown >= 0)
        {
            //時間の管理
            countdown -= Time.deltaTime;
            //時間の表示
            timer.text = "残り時間：" + countdown.ToString("f1");
        }
        //時間切れ後の処理
        else
        {
            //時間の表示
            timer.text = "タイムアップ";
            if(timeup == false)
            {
                //終了を案内
                Instantiate(prefabEndMessage);
                //終了判定を真にする
                timeup = true;
            }
            //一定時間後、リザルト画面にシーン遷移
            else
            {
                timeupTime -= Time.deltaTime;

                if(timeupTime <= 0)
                {
                    SceneManager.LoadScene("ResultScene");
                }
            }
        }
    }

    public static float GetTime()
    {
        return countdown;
    }
}
